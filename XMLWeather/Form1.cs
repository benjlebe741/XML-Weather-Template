using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        //create list to hold day objects
        public static List<Day> days = new List<Day>();

        public Form1()
        {
            InitializeComponent();
            ExtractInfo("Stratford");
          

            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }
        public static void ExtractInfo(string cityName) 
        {
            days.Clear();
            ExtractForecast(cityName);
            ExtractCurrent(cityName);
        }
        public static void ExtractForecast(string cityName)
        {
            string url = "http://api.openweathermap.org/data/2.5/forecast/daily?q=" + cityName + ",CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0";
            XmlReader reader = XmlReader.Create(url);

            while (reader.Read())
            {
                //create a day object
                Day ghostDay = new Day();
                
                //fill day object with required data, going top to bottom:

                reader.ReadToFollowing("time");
                ghostDay.date = reader.GetAttribute("day");

                reader.ReadToFollowing("sun");
                ghostDay.sunRise = reader.GetAttribute("rise");
                ghostDay.sunSet = reader.GetAttribute("set");

                reader.ReadToFollowing("symbol");
                ghostDay.condition = reader.GetAttribute("name");
                ghostDay.symbol = reader.GetAttribute("var");

                reader.ReadToFollowing("precipitation");
                ghostDay.precipitation = reader.GetAttribute("probability");

                reader.ReadToFollowing("windDirection");
                ghostDay.windDirection = reader.GetAttribute("name");

                reader.ReadToFollowing("windSpeed");
                ghostDay.windSpeed = reader.GetAttribute("name");

                reader.ReadToFollowing("temperature");
                //This removes the decimal places on all the decimal values I receive, converting a string into a double, then into an int, then back into a string.
                ghostDay.tempLow = $"{(int)Convert.ToDouble(reader.GetAttribute("min"))}";
                ghostDay.tempHigh = $"{(int)Convert.ToDouble(reader.GetAttribute("max"))}";

                reader.ReadToFollowing("humidity");
                ghostDay.humidity = reader.GetAttribute("value");

                reader.ReadToFollowing("clouds");
                ghostDay.clouds = reader.GetAttribute("value");

                //if day object has info, add to the days list
                if (ghostDay.date != null)
                {
                    days.Add(ghostDay);
                }
            }
        }

        public static void ExtractCurrent(string cityName)
        {
            string url = "http://api.openweathermap.org/data/2.5/weather?q=" + cityName + ",CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0";
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create(url);

            //find the city, current temperature, and 'feels-like' and add them to the appropriate item in days list
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("temperature");
            //remove decimal places
            days[0].currentTemp = $"{(int)Convert.ToDouble(reader.GetAttribute("value"))}";

            reader.ReadToFollowing("feels_like");
            //remove decimal places
            days[0].feelsLike = $"{(int)Convert.ToDouble(reader.GetAttribute("value"))}";
        }


    }
}
