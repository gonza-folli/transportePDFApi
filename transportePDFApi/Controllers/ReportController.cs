using Microsoft.AspNetCore.Mvc;

namespace transportePDFApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportController : ControllerBase
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet(Name = "GetReport")]
        public void Get()
        {
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();
        }

    }
}
