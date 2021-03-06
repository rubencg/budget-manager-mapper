using Newtonsoft.Json;

namespace budget_manager_mapper.Models
{
    public class CategoryOut
    {
        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }
        
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

        [JsonProperty(PropertyName = "subcategories")]
        public string[] Subcategories { get; set; }

    }
}