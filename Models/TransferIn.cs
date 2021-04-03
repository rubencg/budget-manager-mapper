using Newtonsoft.Json;

namespace budget_manager_mapper.Models
{
    public class TransferIn
    {
        [JsonProperty(PropertyName = "amount")]
        public decimal Amount { get; set; }

        [JsonProperty(PropertyName = "date")]
        public long Date { get; set; }

        [JsonProperty(PropertyName = "fromAccount")]
        public TransferAccount FromAccount { get; set; }
        
        [JsonProperty(PropertyName = "toAccount")]
        public TransferAccount ToAccount { get; set; }
    }

    public class TransferAccount{
        [JsonProperty(PropertyName = "img")]
        public string Image { get; set; }
        
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}