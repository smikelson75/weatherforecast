using Microsoft.EntityFrameworkCore;

namespace weather;

public class WeatherForecastDbContext : DbContext
{
    public WeatherForecastDbContext(DbContextOptions<WeatherForecastDbContext> options) : base(options)
    {
    }

    public DbSet<WeatherForecast> WeatherForecasts { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WeatherForecast>().HasData(
            new WeatherForecast
            {
                Id = 1,
                City = "Seattle",
                Date = DateTime.Now,
                TemperatureC = 20,
                Summary = "Cloudy"
            },
            new WeatherForecast
            {
                Id = 2,
                City = "New York",
                Date = DateTime.Now,
                TemperatureC = 25,
                Summary = "Sunny"
            },
            new WeatherForecast
            {
                Id = 3,
                City = "London",
                Date = DateTime.Now,
                TemperatureC = 15,
                Summary = "Rainy"
            },
            new WeatherForecast
            {
                Id = 4,
                City = "Tokyo",
                Date = DateTime.Now,
                TemperatureC = 30,
                Summary = "Sunny"
            },
            new WeatherForecast
            {
                Id = 5,
                City = "Sydney",
                Date = DateTime.Now,
                TemperatureC = 35,
                Summary = "Sunny"
            }
        );
    }
}