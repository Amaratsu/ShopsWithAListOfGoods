using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication2.Models
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mode { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<Product> Products { get; set; }
    }
}