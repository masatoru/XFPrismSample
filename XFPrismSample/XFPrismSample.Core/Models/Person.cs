using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XFPrismSample.Models
{
    public class Person
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "birthday")]
        public DateTimeOffset Birthday { get; set; }
    }
}
