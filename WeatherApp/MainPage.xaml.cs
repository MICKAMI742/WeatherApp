﻿using Microsoft.Maui.Controls;
using System.Security.Cryptography.X509Certificates;
using WeatherApp.Models;
namespace WeatherApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Models.Location location = new Models.Location();
            Weather weather = new Weather();
            var response = await weather.GetCurrentWeatherSync(location);
        }
    }
}