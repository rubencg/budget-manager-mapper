using Newtonsoft.Json;

namespace budget_manager_mapper.Models
{
    public class ExpenseOut
    {
        [JsonProperty(PropertyName = "amount")]
        public decimal Amount { get; set; }
        
        [JsonProperty(PropertyName = "date")]
        public string Date { get; set; }
        
        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; set; }

        [JsonProperty(PropertyName = "fromAccount")]
        public TransferOutAccount Account { get; set; }

        [JsonProperty(PropertyName = "category")]
        public CategoryExpenseOut Category { get; set; }
        
        [JsonProperty(PropertyName = "subcategory")]
        public string Subcategory { get; set; }

    }

    public class CategoryExpenseOut {
        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }
        
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }
    }
}