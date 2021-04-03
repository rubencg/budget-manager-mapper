using Newtonsoft.Json;

namespace budget_manager_mapper.Models
{
    public class AccountType
    {
        public AccountType(string name)
        {
            this.Name = name;
        }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}