using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherWPF
{
    public class Current
    {

        [JsonProperty("last_updated_epoch")]
        public int last_updated_epoch { get; set; }

        [JsonProperty("last_updated")]
        public string last_updated { get; set; }

        [JsonProperty("temp_c")]
        public double temp_c { get; set; }

        [JsonProperty("temp_f")]
        public double temp_f { get; set; }

        [JsonProperty("is_day")]
        public int is_day { get; set; }

        [JsonProperty("condition")]
        public Condition condition { get; set; }

        [JsonProperty("wind_mph")]
        public double wind_mph { get; set; }

        [JsonProperty("wind_kph")]
        public double wind_kph { get; set; }

        [JsonProperty("wind_degree")]
        public int wind_degree { get; set; }

        [JsonProperty("wind_dir")]
        public string wind_dir { get; set; }

        [JsonProperty("pressure_mb")]
        public double pressure_mb { get; set; }

        [JsonProperty("pressure_in")]
        public double pressure_in { get; set; }

        [JsonProperty("precip_mm")]
        public double precip_mm { get; set; }

        [JsonProperty("precip_in")]
        public double precip_in { get; set; }

        [JsonProperty("humidity")]
        public int humidity { get; set; }

        [JsonProperty("cloud")]
        public int cloud { get; set; }

        [JsonProperty("feelslike_c")]
        public double feelslike_c { get; set; }

        [JsonProperty("feelslike_f")]
        public double feelslike_f { get; set; }

        [JsonProperty("vis_km")]
        public double vis_km { get; set; }

        [JsonProperty("vis_miles")]
        public double vis_miles { get; set; }

        [JsonProperty("uv")]
        public double uv { get; set; }
    }

}
