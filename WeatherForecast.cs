using System.ComponentModel.DataAnnotations;

namespace weather;

public class WeatherForecast
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string City { get; set; } = null!;
    [Required]
    public DateTime Date { get; set; }
    [Required]
    public int TemperatureC { get; set; }
    public string? Summary { get; set; }
}
