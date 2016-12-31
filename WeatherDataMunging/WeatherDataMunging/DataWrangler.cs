using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace WeatherDataMunging
{
    public static class DataWrangler
    {
        public static List<WeatherData> ProcessData(string filePath)
        {
            var weatherDataList = new List<WeatherData>();

            string weatherDataFile = File.ReadAllText(filePath);
            Regex regex = new Regex(@".*  (\d{1,2})  (\d{1,3}) +(\d{1,3})", RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(weatherDataFile);
            foreach (Match match in matches)
            {
                var weatherData = new WeatherData
                {
                    Day = Convert.ToInt32(match.Groups[1].Value),
                    MaxTemperature = Convert.ToInt32(match.Groups[2].Value),
                    MinTemperature = Convert.ToInt32(match.Groups[3].Value)
                };
                weatherDataList.Add(weatherData);
            }

            return weatherDataList;
        }
    }
}
