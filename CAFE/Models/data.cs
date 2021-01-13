using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAFE.Models
{
    public class data
    {
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("price")]
        public string price { get; set; }
        [JsonProperty("quantity")]
        public string quantity { get; set; }
    }
}
