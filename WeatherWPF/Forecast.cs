using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherWPF
{
    public class Forecast
    {

        [JsonProperty("forecastday")]
        public IList<ForeCastday> forecastday { get; set; }
    }
}
