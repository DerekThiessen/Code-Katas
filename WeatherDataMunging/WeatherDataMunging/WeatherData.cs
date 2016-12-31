using System;

namespace WeatherDataMunging
{
    public class WeatherData
    {
        public int Day { get; set; }
        public int MaxTemperature { get; set; }
        public int MinTemperature { get; set; }
        public int CalculateTemperatureSpread
        {
            get
            {
                return Math.Abs(MaxTemperature - MinTemperature);
            }
        }
    }
}
