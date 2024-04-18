using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string date, symbol, sunRise, sunSet, feelsLike, currentTemp, condition, location, tempHigh, tempLow, 
            windSpeed, windDirection, precipitation, humidity, clouds;

        public Day()
        {
            date = symbol = sunRise = sunSet = feelsLike = currentTemp = condition = location = tempHigh = tempLow
                = windSpeed = windDirection = precipitation = humidity = clouds = "";
        }
    }
}
