using Newtonsoft.Json;

namespace budget_manager_mapper.Models
{
    public class AccountIn
    {
        [JsonProperty(PropertyName = "currentBalance")]
        public decimal CurrentBalance { get; set; }

        [JsonProperty(PropertyName = "img")]
        public string Image { get; set; }

        [JsonProperty(PropertyName = "isSummable")]
        public string IsSummable { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }
}