using System.Collections.Generic;
using System.Linq;

namespace WeatherDataMunging
{
    public static class DataFilter
    {
        public static WeatherData GetSmallestTemperatureSpread(List<WeatherData> weatherData)
        {
            var sortedTemperatureSpreads = weatherData.OrderBy(x => x.CalculateTemperatureSpread).ToList();
            return sortedTemperatureSpreads.First();
        }
    }
}
