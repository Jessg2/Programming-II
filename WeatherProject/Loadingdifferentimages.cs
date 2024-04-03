using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherProject
{
    internal class Loadingdifferentimages
    {
        public void ShowWeatherGraphic()
        {
            if (currentTemperature.WeatherDescription.ToLower().Contains("sun"))
            {
                WeatherGraphic.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + "../../media/sun.png", UriKind.Absolute));

            }
            else if (currentTemperature.WeatherDescription.ToLower().Contains("cloud"))
            {
                WeatherGraphic.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + "../../media/clouds.png", UriKind.Absolute));
            }
            else
                WeatherGraphic.Source = new BitmapImage(new Uri("DefaultImage.bmp", UriKind.Relative));
        }
    }
}
