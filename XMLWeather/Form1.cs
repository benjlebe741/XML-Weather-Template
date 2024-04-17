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
        public void ExtractInfo(string cityName) 
        {
            ExtractForecast(cityName);
            ExtractCurrent(cityName);
        }
        private void ExtractForecast(string cityName)
        {
            string url = "http://api.openweathermap.org/data/2.5/forecast/daily?q=" + cityName + ",CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0";
            XmlReader reader = XmlReader.Create(url);

            while (reader.Read())
            {
                //create a day object
                Day ghostDay = new Day();
                //currentTime, location;
                //fill day object with required data
                reader.ReadToFollowing("time");
                ghostDay.date = reader.GetAttribute("day");

                reader.ReadToFollowing("sun");
                ghostDay.sunRise = reader.GetAttribute("rise");
                ghostDay.sunSet = reader.GetAttribute("set");

                reader.ReadToFollowing("symbol");
                ghostDay.condition = reader.GetAttribute("name");

                reader.ReadToFollowing("precipitation");
                ghostDay.precipitation = reader.GetAttribute("probability");

                reader.ReadToFollowing("windDirection");
                ghostDay.windDirection = reader.GetAttribute("name");

                reader.ReadToFollowing("windSpeed");
                ghostDay.windSpeed = reader.GetAttribute("name");

                reader.ReadToFollowing("temperature");
                ghostDay.tempLow = $"{(int)Convert.ToDouble(reader.GetAttribute("min"))}";
                ghostDay.tempHigh = $"{(int)Convert.ToDouble(reader.GetAttribute("max"))}";

                reader.ReadToFollowing("humidity");
                ghostDay.humidity = reader.GetAttribute("value");

                reader.ReadToFollowing("clouds");
                ghostDay.clouds = reader.GetAttribute("value");

                //if day object not null add to the days list
                if (ghostDay.date != null)
                {
                    days.Add(ghostDay);
                }
            }
        }

        private void ExtractCurrent(string cityName)
        {
            string url = "http://api.openweathermap.org/data/2.5/weather?q=" + cityName + ",CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0";
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create(url);

            //find the city and current temperature and add to appropriate item in days list
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");
           
            reader.ReadToFollowing("temperature");
            days[0].currentTemp = $"{(int)Convert.ToDouble(reader.GetAttribute("value"))}";

            reader.ReadToFollowing("feels_like");
            days[0].feelsLike = $"{(int)Convert.ToDouble(reader.GetAttribute("value"))}";
        }


    }
}
