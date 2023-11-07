using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    internal class Location
    {
        public double latitude {  get; set; }
        public double longitude { get; set; }

        public async Task<(double,double)> GetLocationAsync()
        {
            var location = await Geolocation.GetLocationAsync();
            try
            {
                if (location != null)
                {
                    this.latitude = location.Latitude;
                    this.longitude = location.Longitude;
                    return (location.Latitude, location.Longitude);
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                Console.WriteLine($"{fnsEx.Message}");
                Console.WriteLine($"{latitude} {longitude}");
            }
            return (0,0);
        }
    }
}
