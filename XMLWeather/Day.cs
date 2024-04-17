using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string date, sunRise, sunSet, feelsLike, currentTemp, condition, location, tempHigh, tempLow, 
            windSpeed, windDirection, precipitation, humidity, clouds;

        public Day()
        {
            date = sunRise = sunSet = feelsLike = currentTemp = condition = location = tempHigh = tempLow
                = windSpeed = windDirection = precipitation = humidity = clouds = "";
        }
    }
}
