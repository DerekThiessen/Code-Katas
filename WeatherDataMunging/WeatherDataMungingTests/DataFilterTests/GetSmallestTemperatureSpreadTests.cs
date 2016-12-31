using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using WeatherDataMunging;

namespace WeatherDataMungingTests.DataFilterTests
{
    [TestClass]
    public class SmallestTemperatureSpreadTests
    {
        private List<WeatherData> _weatherData;

        [TestInitialize]
        public void Init()
        {
            _weatherData = new List<WeatherData>();
        }

        [TestMethod]
        public void GetSmallestTemperatureSpread()
        {
            AddWeatherData(1, 50, 40);
            AddWeatherData(2, 55, 48);
            AddWeatherData(3, 88, 75);

           var actual = DataFilter.GetSmallestTemperatureSpread(_weatherData);
            Assert.AreEqual(2, actual.Day);
        }

        private void AddWeatherData(int day, int max, int min)
        {
            var weatherData = new WeatherData
            {
                Day = day,
                MaxTemperature = max,
                MinTemperature = min
            };
            _weatherData.Add(weatherData);
        }
    }
}
