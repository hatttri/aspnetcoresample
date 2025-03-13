using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<WeatherForecast> Post(WeatherForecastRequest req)
        {
            await Task.Delay(230 * 1000);

            return new WeatherForecast
            {
                Name = "OK"
            };
        }
    }
}
