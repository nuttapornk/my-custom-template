using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Application.Weather.Queries.GetWeatherForecasts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class WeatherForecast : ApiControllerBase
{
    private readonly ILogger<WeatherForecast> _logger;

    public WeatherForecast(ILogger<WeatherForecast> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "WeatherForecasts")]
    public async Task<IEnumerable<WeatherForecastsResponse>> Get()
        => await Mediator.Send(new GetWeatherForecastsQuery());

}
