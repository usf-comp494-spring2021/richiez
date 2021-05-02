using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RZielinski_Final_Project_2021.Models
{
    // in this class all of the variables are reterived from the API (weather forecast endpoint) and recognized by the application
    // the data types are set and it is now ready for use in a view 
    public class WeatherForecast
    {
        public DateTime forecastDate { get; set; }

        public string location { get; set; }

        public double temperature { get; set; }

        public double feelsLike { get; set; }

        public string descriptor { get; set; }

        public string imagePath { get; set; }

        public double windSpeed { get; set; }

        public string windDirection { get; set; }

        public double pressure { get; set; }
    }
}
