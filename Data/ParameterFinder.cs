using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolvaBot.Data
{
    public class ParameterFinder
    {
        public Task GetForecastAsync()
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }

    }
}
