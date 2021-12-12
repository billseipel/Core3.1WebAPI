using Core3dot1WebAPI.Managers;
using Core3dot1WebAPI.Managers.Interfaces;
using Core3dot1WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core3dot1WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private IWeatherForecastManager WeatherForeCastManager { get; set; }

        public WeatherForecastController(IWeatherForecastManager weatherforecastmanager)
        {
            WeatherForeCastManager = weatherforecastmanager;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return WeatherForeCastManager.GetWeatherForecast();
        }
    }
}
