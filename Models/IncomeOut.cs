using Newtonsoft.Json;

namespace budget_manager_mapper.Models
{
    public class IncomeOut
    {
        [JsonProperty(PropertyName = "amount")]
        public decimal Amount { get; set; }
        
        [JsonProperty(PropertyName = "date")]
        public string Date { get; set; }

        [JsonProperty(PropertyName = "isApplied")]
        public bool IsApplied { get; set; }
                
        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; set; }

        [JsonProperty(PropertyName = "toAccount")]
        public TransferOutAccount Account { get; set; }

        [JsonProperty(PropertyName = "category")]
        public CategoryExpenseOut Category { get; set; }
        
        [JsonProperty(PropertyName = "subcategory")]
        public string Subcategory { get; set; }
    }
}