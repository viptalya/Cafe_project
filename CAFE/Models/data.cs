using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAFE.Models
{
    public class Root
    {
        [JsonProperty("items")]
        public Dat[] Dat { get; set; }
    }
    public class Dat
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("price")]
        public string Price { get; set; }
        [JsonProperty("quantity")]
        public string Quantity { get; set; }
    }
}
