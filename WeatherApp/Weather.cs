using System;

/*****************************************/
/*  Project 4:   Weather Today           */
/*  Author:      Lynn Eades              */
/*  Date:        10/28/2018              */
/*****************************************/

namespace WeatherApp
{
    class Weather
    {
        // Getters and setters for weather values
        public int highTemperature { get; set; }
        public int lowTemperature { get; set; }
        public int windSpeed { get; set; }
        public string skyCondition { get; set; }

        // Returns wind chill in degrees Fahrenheit; uses low temperature for calculation
        // Wind Chill = 35.74 + 0.6215T – 35.75(V^0.16) + 0.4275T(V^0.16)
        public int WindChill()
        {
            // Only calculate wind chill for wind speeds greater than zero
            if (windSpeed > 0)
            {
                double windChill = 35.74 + (0.6215 * lowTemperature) - (35.75 * Math.Pow(windSpeed, 0.16)) + (0.4275 * lowTemperature * Math.Pow(windSpeed, 0.16));

                // Round the value and return as an integer
                return (int)Math.Round(windChill);
            }
            // If no wind, return just the low temperature
            else
            {
                return this.lowTemperature;
            }
        }

        // Returns a string URL for sky condition image file
        public string SkyConditionFile()
        {
            string imageUrl = "";

            switch(skyCondition)
            {
                case ("Clear"):
                    imageUrl = "./Images/clear.jpg";
                    break;
                case ("Cloudy"):
                    imageUrl = "./Images/cloudy.jpg";
                    break;
                case ("Partly Cloudy"):
                    imageUrl = "./Images/partlycloudy.jpg";
                    break;
                case ("Rain"):
                    imageUrl = "./Images/rain.jpg";
                    break;
                default:
                    break;
            }
            return imageUrl;
        }
    }
}
