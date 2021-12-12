using Core3dot1WebAPI.Models;
using System.Collections.Generic;

namespace Core3dot1WebAPI.Managers.Interfaces
{
    public interface IWeatherForecastManager
    {
        IEnumerable<WeatherForecast> GetWeatherForecast();
    }
}
