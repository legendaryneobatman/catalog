using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    private int CalculateFibonacciNumber(int number)
    {
        if (number <= 1)
        {
            return number;
        }
        else
        {
            return this.CalculateFibonacciNumber(number - 1) + this.CalculateFibonacciNumber(number - 2);
        }
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        var temperatureC = Random.Shared.Next(-20, 50);
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = temperatureC,
                Summary = Summaries[Random.Shared.Next(Summaries.Length)],
                Humidity = $"{Random.Shared.Next(0, 100).ToString()}%",
                FibonacciTemperatureC = this.CalculateFibonacciNumber(temperatureC)
            })
            .ToArray();
    }
}