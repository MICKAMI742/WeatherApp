using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using Newtonsoft.Json;

namespace WeatherApp.Models
{
    class Weather
    {
        public string address {  get; set; }
        public DateTime datetime {  get; set; }
        public int tempMax {  get; set; }
        public int tempMin { get; set; }

        public async Task<Weather> GetCurrentWeatherSync()
        {
            var client = new HttpClient();
            Location location = new Location();
            var position = location.GetLocationAsync();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://weather.visualcrossing.com/VisualCrossingWebServices/rest" +
                                     $"/services/timeline/{location.latitude},{location.longitude}?key=XBTHKQ9HX4WR2LXSV4TVGYJMG")
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var responseObject = await response.Content.ReadAsStringAsync();
                var weather = JsonConvert.DeserializeObject<Weather>(responseObject);
                return weather;
            }
        }
    }
}
