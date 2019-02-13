using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherWPF
{
    public class Astro
    {

        [JsonProperty("sunrise")]
        public string sunrise { get; set; }

        [JsonProperty("sunset")]
        public string sunset { get; set; }

        [JsonProperty("moonrise")]
        public string moonrise { get; set; }

        [JsonProperty("moonset")]
        public string moonset { get; set; }
    }
}
