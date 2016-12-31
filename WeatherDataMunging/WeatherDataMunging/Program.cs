using System;
using System.Collections.Generic;
using System.IO;

namespace WeatherDataMunging
{
    class Program
    {
        static void Main(string[] args)
        {
            const string filePath = @"c:\users\derek\source\repos\code-katas\weatherdatamunging\weather.dat";

            try
            {
                List<WeatherData> weatherData = DataWrangler.ProcessData(filePath);
                if(weatherData.Count > 0)
                {
                    var smallestTemperatureSpread = DataFilter.GetSmallestTemperatureSpread(weatherData);
                    var output = FormatOutput(smallestTemperatureSpread);
                    Console.WriteLine(output);
                }
                else
                {
                    Console.WriteLine("No weather data...\n");
                }

            }
            catch(DirectoryNotFoundException)
            {
                Console.WriteLine("Directory not found...\n");
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("File not found...\n");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static string FormatOutput(WeatherData smallestTemperatureSpread)
        {
            return "Day: " + smallestTemperatureSpread.Day + "\n" +
                "Max temperature: " + smallestTemperatureSpread.MaxTemperature + "\n" +
                "Minimum temperature: " + smallestTemperatureSpread.MinTemperature + "\n" +
                "Spread: " + smallestTemperatureSpread.CalculateTemperatureSpread + "\n";
        }
    }
}
