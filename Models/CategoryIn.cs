using Newtonsoft.Json;

namespace budget_manager_mapper.Models
{
    public class CategoryIn
    {
        [JsonProperty(PropertyName = "img")]
        public string Image { get; set; }
        
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "subcategories")]
        public SubcategoryIn[] Subcategories { get; set; }

    }
}