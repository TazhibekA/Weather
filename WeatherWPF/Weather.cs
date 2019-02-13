using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherWPF
{
    public class Weather
    {

        [JsonProperty("location")]
        public Location location { get; set; }

        [JsonProperty("current")]
        public Current current { get; set; }

        [JsonProperty("forecast")]
        public Forecast forecast { get; set; }
    }
}
