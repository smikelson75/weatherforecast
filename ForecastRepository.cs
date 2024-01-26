
using Microsoft.EntityFrameworkCore;

namespace weather;

public class ForecastRepository : IRepository
{
    private readonly WeatherForecastDbContext _context;
    public ForecastRepository(WeatherForecastDbContext context)
    {
        _context = context;
    }
    public Task<WeatherForecastDto> GetWeatherForecastAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<WeatherForecastDto>> GetWeatherForecastsAsync()
    {
        var weatherForecasts = await this._context.WeatherForecasts.ToListAsync();
        return weatherForecasts.Select(wf => new WeatherForecastDto
        {
            City = wf.City,
            Date = wf.Date,
            TemperatureC = wf.TemperatureC,
            Summary = wf.Summary
        });
    }
}