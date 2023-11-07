using System.Text.Json.Nodes;

namespace WeatherApp.Models
{
    class WeeklyForecast
    {
        public string Adress { get; set; }
        List<JsonArray> days { get; set; }

        //public static async Task getData()
        //{
        //    var client = new HttpClient();
        //    var request = new HttpRequestMessage 
        //    { 
        //        Method = HttpMethod.Get, 
        //        RequestUri = new Uri("https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/London,UK?key=XBTHKQ9HX4WR2LXSV4TVGYJMG") 
        //    };
        //    using(var response = await client.SendAsync(request))
        //    {
        //        response.EnsureSuccessStatusCode();
        //        var body = await response.Content.ReadAsStringAsync();
        //    }
        //}
    }
}
