using Core3dot1WebAPI.Models;
using System.Collections.Generic;

namespace Core3dot1WebAPI.Repositories.Interfaces
{
    public interface IWeatherForecastRepo
    {
        IEnumerable<WeatherForecast> GetWeatherForecast();
    }
}
