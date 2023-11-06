using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    class Weather
    {
        public string adress {  get; set; }
        public DateTime date {  get; set; }
        public int tempMax {  get; set; }
        public int tempMin { get; set; }
    }
}
