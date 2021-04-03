using Newtonsoft.Json;

namespace budget_manager_mapper.Models
{
    public class SubcategoryIn
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}