using Core3dot1WebAPI.Managers.Interfaces;
using Core3dot1WebAPI.Models;
using Core3dot1WebAPI.Repositories.Interfaces;
using System.Collections.Generic;

namespace Core3dot1WebAPI.Managers
{
    public class WeatherForecastManager : IWeatherForecastManager
    {
       private IWeatherForecastRepo WeatherForecastRepo { get; set; }

        public WeatherForecastManager(IWeatherForecastRepo weatherforecastrepo)
        {
            WeatherForecastRepo = weatherforecastrepo;
        }

        public IEnumerable<WeatherForecast> GetWeatherForecast()
        {
            return WeatherForecastRepo.GetWeatherForecast();
        }
    }
}
