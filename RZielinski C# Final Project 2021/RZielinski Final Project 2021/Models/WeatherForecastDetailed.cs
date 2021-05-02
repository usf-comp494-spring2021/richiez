using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RZielinski_Final_Project_2021.Models
{
    // in this class all of the variables are reterived from the API (detailed weather forecast endpoint) and recognized by the application
    // the data types are set and it is now ready for use in a view 
    // notice the repeating varibles are accounted for via inheritence
    public class WeatherForecastDetailed : WeatherForecast
    {
        public int visability {get; set;}

        public string clouds { get; set; }

        public int humidity { get; set; }

        public double rainfall { get; set; }

        public double snowfall { get; set; }
    }
}
