using Newtonsoft.Json;

namespace budget_manager_mapper.Models
{
    public class IncomeIn
    {
        [JsonProperty(PropertyName = "amount")]
        public decimal Amount { get; set; }

        [JsonProperty(PropertyName = "category")]
        public CategoryExpenseIn Category { get; set; }

        [JsonProperty(PropertyName = "date")]
        public long Date { get; set; }
        
        [JsonProperty(PropertyName = "isApplied")]
        public bool IsApplied { get; set; }
        
        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; set; }

        [JsonProperty(PropertyName = "toAccount")]
        public AccountExpenseIn Account { get; set; }
    }
}