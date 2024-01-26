namespace weather;

public interface IRepository
{
    Task<WeatherForecastDto> GetWeatherForecastAsync(int id);
    Task<IEnumerable<WeatherForecastDto>> GetWeatherForecastsAsync();
    // Task<WeatherForecastDto> CreateWeatherForecastAsync(WeatherForecastDto weatherForecastDto);
    // Task<WeatherForecastDto> UpdateWeatherForecastAsync(WeatherForecastDto weatherForecastDto);
    // Task DeleteWeatherForecastAsync(int id);
}