using Newtonsoft.Json;

namespace budget_manager_mapper.Models
{
    public class TransferOut
    {
        [JsonProperty(PropertyName = "amount")]
        public decimal Amount { get; set; }

        [JsonProperty(PropertyName = "date")]
        public string Date { get; set; }

        [JsonProperty(PropertyName = "fromAccount")]
        public TransferOutAccount FromAccount { get; set; }
        
        [JsonProperty(PropertyName = "toAccount")]
        public TransferOutAccount ToAccount { get; set; }
    }

    public class TransferOutAccount{
        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }
        
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }
    }
}