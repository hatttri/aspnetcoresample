using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public WeatherForecastController()
        {
        }

        [HttpGet("10")]
        public async Task<string> GetDelay10()
        {
            await Task.Delay(10 * 1000);
            return "OK";
        }

        [HttpGet("20")]
        public async Task<string> GetDelay20()
        {
            await Task.Delay(20 * 1000);
            return "OK";
        }
    }
}
