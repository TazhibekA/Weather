using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherWPF
{
    public class Day
    {

        [JsonProperty("maxtemp_c")]
        public double maxtemp_c { get; set; }

        [JsonProperty("maxtemp_f")]
        public double maxtemp_f { get; set; }

        [JsonProperty("mintemp_c")]
        public double mintemp_c { get; set; }

        [JsonProperty("mintemp_f")]
        public double mintemp_f { get; set; }

        [JsonProperty("avgtemp_c")]
        public double avgtemp_c { get; set; }

        [JsonProperty("avgtemp_f")]
        public double avgtemp_f { get; set; }

        [JsonProperty("maxwind_mph")]
        public double maxwind_mph { get; set; }

        [JsonProperty("maxwind_kph")]
        public double maxwind_kph { get; set; }

        [JsonProperty("totalprecip_mm")]
        public double totalprecip_mm { get; set; }

        [JsonProperty("totalprecip_in")]
        public double totalprecip_in { get; set; }

        [JsonProperty("avgvis_km")]
        public double avgvis_km { get; set; }

        [JsonProperty("avgvis_miles")]
        public double avgvis_miles { get; set; }

        [JsonProperty("avghumidity")]
        public double avghumidity { get; set; }

        [JsonProperty("condition")]
        public Condition condition { get; set; }

        [JsonProperty("uv")]
        public double uv { get; set; }
    }
}

