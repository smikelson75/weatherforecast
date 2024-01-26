using Microsoft.AspNetCore.Mvc;

namespace weather.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IRepository _weather;

    public WeatherForecastController(
        ILogger<WeatherForecastController> logger,
        IRepository weather)
    {
        _logger = logger;
        _weather = weather;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<ActionResult<IEnumerable<WeatherForecastDto>>> Get()
    {
        return Ok(await _weather.GetWeatherForecastsAsync());
    }
}
