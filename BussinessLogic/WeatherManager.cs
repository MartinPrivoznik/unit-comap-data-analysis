using System;
using System.Threading.Tasks;
using UnIT_ComAp.Models;

namespace UnIT_ComAp.BussinessLogic
{
    public class WeatherManager
    {
        private readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public WeatherManager()
        {
        }

        public async Task InsertWeather()
        {
            var rng = new Random();
        }
    }
}
