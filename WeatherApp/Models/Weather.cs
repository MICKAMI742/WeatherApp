namespace WeatherApp.Models
{
    class Weather
    {
        public string address { get; set; }
        public DateTime datetime { get; set; }
        public int tempMax { get; set; }
        public int tempMin { get; set; }

        public async Task<string> GetCurrentWeatherSync(Location location)
        {
            //var client = new HttpClient();
            //var position = location.GetLocationAsync();
            //var request = new HttpRequestMessage
            //{
            //    Method = HttpMethod.Get,
            //    RequestUri = new Uri($"https://weather.visualcrossing.com/VisualCrossingWebServices/rest" +
            //                         $"/services/timeline/{position.Result.Item1},{position.Result.Item2}?key=XBTHKQ9HX4WR2LXSV4TVGYJMG")
            //};
            //using (var response = await client.SendAsync(request))
            //{
            //    response.EnsureSuccessStatusCode();
            //    var responseObject = await response.Content.ReadAsStringAsync();
            //    var weather = JsonConvert.DeserializeObject<Weather>(responseObject);
            //    return weather;
            //}

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var position = location.GetLocationAsync();
                    var url = new Uri($"https://weather.visualcrossing.com/VisualCrossingWebServices/rest" +
                                        $"/services/timeline/{position.Result.Item1},{position.Result.Item2}?key=XBTHKQ9HX4WR2LXSV4TVGYJMG");
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
                }catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return null;
                }
                return null;
            }
        }

        public void GetCityName(Location location)
        {

        }
    }
}
