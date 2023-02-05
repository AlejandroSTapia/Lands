using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lands.Models
{
    public class Currency
    {
        //Colocamos un alias a cada prop

        //Lo recibimos del json como code pero internamente como Code
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "symbol")]
        public string Symbol { get; set; }
    }
}
