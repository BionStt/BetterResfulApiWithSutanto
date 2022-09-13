using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.ModelSampleForResponseSwagger
{
    public class WeatherForecastExample : IMultipleExamplesProvider<WeatherForecast>
    {
        public IEnumerable<SwaggerExample<WeatherForecast>> GetExamples()
        {
            yield return SwaggerExample.Create(
                "Example 1",
                new WeatherForecast { 
                Date = DateTime.Now,
                Summary="Chilly",
                TemperatureC = 40
                });

            yield return SwaggerExample.Create(
               "Example 2",
               new WeatherForecast
               {
                   Date = DateTime.Now,
                   Summary = "Warm",
                   TemperatureC = 48
               });
        }
    }
}
