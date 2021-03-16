using DemoWebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoWebService.Controllers
{
    public class WeatherController : ApiController
    {
        // GET: api/Weather
        public IEnumerable<WeatherInfo> Get()
        {
            var weatherInList = new List<WeatherInfo>();
            for(int i = 0; i<10; i++)
            {
                var WeatherInfo = new WeatherInfo
                {
                    Location = $"Location {i}",
                    Degree = i * 23 / 17,
                    DateTime = DateTime.Now.ToUniversalTime(),
                };
                weatherInList.Add(WeatherInfo);
            }
            return weatherInList;
        }

        // GET: api/Weather/5
        public WeatherInfo Get(int id)
        {
            return new WeatherInfo
            {
                Location = $"Location {id}",
                Degree = id * 23 / 17,
                DateTime = DateTime.Now.ToUniversalTime()
            }; ;
        }

      
    }
}
