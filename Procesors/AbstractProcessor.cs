using System.IO;
using System.Linq;
using System.Text.Json;
using AutoMapper;
using budget_manager_mapper.Models;
using budget_manager_mapper.Profiles;
using Newtonsoft.Json;

namespace budget_manager_mapper.Procesors
{
    public class Processor : IProcessor
    {
        protected IMapper _mapper;
        public Processor()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<AccountProfile>();
                cfg.AddProfile<CategoryProfile>();
                cfg.AddProfile<TransferProfile>();
                cfg.AddProfile<ExpenseProfile>();
                cfg.AddProfile<IncomeProfile>();
            });
            _mapper = config.CreateMapper();
        }

        public void processFile<T, K>(string fileName, string outputFilename)
        {
            var inArray = GetJsonFromFile<T[]>(fileName);
            var outArray = _mapper.Map<K[]>(inArray);

            this.SaveJson<K>(outArray, outputFilename);
        }

        protected T GetJsonFromFile<T>(string fileName){
            var jsonString = File.ReadAllText(fileName);

            return JsonConvert.DeserializeObject<T>(jsonString);
        }

        protected void SaveJson<T>(T[] data, string outputFilename){
            var firebaseKeyObject = new FirebaseKeyObject();
            var counter = 0;

            data.ToList().ForEach(dataElement => firebaseKeyObject.Elements.Add("-Kc08K-i6rbuNEpxO" + counter++, dataElement));

            var jsonString = JsonConvert.SerializeObject(firebaseKeyObject);
            File.WriteAllText(outputFilename, jsonString);
        }
    }
}