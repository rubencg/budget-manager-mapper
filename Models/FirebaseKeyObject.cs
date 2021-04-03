using System.Collections.Generic;

namespace budget_manager_mapper.Models
{
    public class FirebaseKeyObject
    {
        public FirebaseKeyObject()
        {
            this.Elements = new Dictionary<string, object>();
        }
        public IDictionary<string, object> Elements { get; set; }
    }
}