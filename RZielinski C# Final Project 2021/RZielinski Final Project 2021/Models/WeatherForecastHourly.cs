using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RZielinski_Final_Project_2021.Models
{
    // in this class all of the variables are reterived from the API (hourly weather forecast endpoint) and recognized by the application
    // the data types are set and it is now ready for use in a view 
    // notice that all repeating variables were accounted for via inheritence
    public class WeatherForecastHourly : WeatherForecast
    {
        public int precipitationPercent { get; set; }

        public double precipitationAmount { get; set; }

        public int cloudCover { get; set; }

        public int dewPoint { get; set; }

        public int humidity { get; set; }

    }
}
