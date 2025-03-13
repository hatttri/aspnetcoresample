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
        public async Task<string> GetDelay200()
        {
            await Task.Delay(200 * 1000);
            return "OK";
        }

        [HttpGet("20")]
        public async Task<string> GetDelay260()
        {
            await Task.Delay(260 * 1000);
            return "OK";
        }
    }
}
