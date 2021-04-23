using Newtonsoft.Json;

namespace budget_manager_mapper.Models
{
    public class AccountOut
    {
        [JsonProperty(PropertyName = "currentBalance")]
        public decimal CurrentBalance { get; set; }

        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }

        [JsonProperty(PropertyName = "sumsToMonthlyBudget")]
        public bool IsSummable { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "accountType")]
        public AccountType AccountType { get; set; }

        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }
    }
}