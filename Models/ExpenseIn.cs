using Newtonsoft.Json;

namespace budget_manager_mapper.Models
{
    public class ExpenseIn
    {
        [JsonProperty(PropertyName = "amount")]
        public decimal Amount { get; set; }

        [JsonProperty(PropertyName = "category")]
        public CategoryExpenseIn Category { get; set; }

        [JsonProperty(PropertyName = "date")]
        public long Date { get; set; }
        
        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; set; }

        [JsonProperty(PropertyName = "fromAccount")]
        public AccountExpenseIn Account { get; set; }
    }

    public class CategoryExpenseIn
    {
        [JsonProperty(PropertyName = "img")]
        public string Image { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "subcategory")]
        public SubcategoryIn Subcategory { get; set; }
    }

    public class AccountExpenseIn
    {
        [JsonProperty(PropertyName = "img")]
        public string Image { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}