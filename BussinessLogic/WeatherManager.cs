using System;
using System.Threading.Tasks;
using UnIT_ComAp.Models;
using UnIT_ComAp.RemoteDatabase;

namespace UnIT_ComAp.BussinessLogic
{
    public class WeatherManager
    {
        private readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly FirebaseClient _firebaseClient;

        public WeatherManager(FirebaseClient firebaseClient)
        {
            _firebaseClient = firebaseClient;
        }

        public async Task InsertWeather()
        {
            var rng = new Random();
            await _firebaseClient.Insert(new Weather
            {
                Date = DateTime.Now,
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }
    }
}
