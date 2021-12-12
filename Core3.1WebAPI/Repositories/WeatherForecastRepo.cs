using Core3._1WebAPI.Configuration;
using Core3dot1WebAPI.Configuration.Interfaces;
using Core3dot1WebAPI.Models;
using Core3dot1WebAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core3dot1WebAPI.Repositories
{
    public class WeatherForecastRepo : IWeatherForecastRepo
    {
        private Core3dot1WebAPIConfiguration Config { get; set;  }
        private static string[] Summaries { get; set; }

        public WeatherForecastRepo(IConfigRetriever config)
        {
            Config = config.Get();
            Summaries = Config.Summaries.Split(',');
        }
        public IEnumerable<WeatherForecast> GetWeatherForecast()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
