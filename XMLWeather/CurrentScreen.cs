using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Resources;
using XMLWeather.Properties;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        //Background Colors
        Color coldColor = Color.FromArgb(100, 205, 255);
        Color hotColor = Color.FromArgb(250, 105, 30);
        const int COLD_TEMP = -20;
        const int HOT_TEMP = 40;
        //The closer the current min and max temperature gets to COLD_TEMP & HOT_TEMP:
        //The more the background color will match the 'coldest' or 'hottest' color value!
        Color minColor, maxColor;
        double hueShiftValue = 6; //How much the opacity of the background colors should change.

        Font defaultTempFont;
        double time = 1;

        double minTemp;
        double maxTemp;

        Label[] onScreenLabels;
        public CurrentScreen()
        {
            InitializeComponent();

            DisplayCurrent();

            defaultTempFont = currentTempOutput.Font;

            onScreenLabels = new Label[]
            {
                todayLabel, forecastLabel, feelsLikeOutput, humidityOutput, precipitationOutput, cloudsOutput, windSpeedOutput, windDirectionOutput
            };

        }

        Color determineColor(double temperature)
        {
            //Find where the temperature lies on the scale from coldest to hottest, 
            //The lower 'hotness' or 'coolness' is, the more of that color will be introduced.
            temperature = (temperature > HOT_TEMP) ? HOT_TEMP : temperature;
            temperature = (temperature < COLD_TEMP) ? COLD_TEMP : temperature;

            double hotness = ((temperature + Math.Abs(COLD_TEMP)) / (HOT_TEMP + Math.Abs(COLD_TEMP))) + 0.0001;

            int r = (int)((coldColor.R * (1 - hotness)) + (hotColor.R * hotness));
            int g = (int)((coldColor.G * (1 - hotness)) + (hotColor.G * hotness));
            int b = (int)((coldColor.B * (1 - hotness)) + (hotColor.B * hotness));

            Color ghostColor = Color.FromArgb(r, g, b);
            return ghostColor;
        }

        public void DisplayCurrent()
        {
            Day today = Form1.days[0];

            minTemp = Convert.ToDouble(today.tempLow);
            maxTemp = Convert.ToDouble(today.tempHigh);

            cityOutput.Text = today.location;
            currentTempOutput.Text = $"{today.currentTemp}°";
            highLowOutput.Text = $"H: {maxTemp}°, L: {minTemp}°";
            statusOutput.Text = today.condition;
            feelsLikeOutput.Text = $"feels like {today.feelsLike}°";
            humidityOutput.Text = $"humidity at {today.humidity}%";
            precipitationOutput.Text = $"precipitation at {today.precipitation}%";
            cloudsOutput.Text = today.clouds;
            windSpeedOutput.Text = today.windSpeed;
            windDirectionOutput.Text = today.windDirection;

            minColor = determineColor(minTemp);
            maxColor = determineColor(maxTemp);

            ResourceManager rm = Resources.ResourceManager;
            string pngName = "_" + today.symbol;
            imageLabel.Image = (Image)rm.GetObject(pngName);
        }

        private void CurrentScreen_Paint(object sender, PaintEventArgs e)
        {
            double sinValue = Math.Abs(Math.Sin(time)) + 0.00001;
            int r = (int)((minColor.R * (sinValue)) + (maxColor.R * (1 - sinValue)));
            int g = (int)((minColor.G * (sinValue)) + (maxColor.G * (1 - sinValue)));
            int b = (int)((minColor.B * (sinValue)) + (maxColor.B * (1 - sinValue)));
            BackColor = Color.FromArgb(r, g, b);


            double hueShift = (2 - Math.Sin(2 * time)) * hueShiftValue;
            double opacity = onScreenLabels.Count() * hueShift;
            foreach (Label label in onScreenLabels)
            {
                label.BackColor = Color.FromArgb((int)opacity, 0 + (r / 3), 20 + (g / 3), 130 + (b / 3));
                opacity -= hueShift;
            }

            currentTempOutput.Font = new Font(defaultTempFont.Name, (float)(defaultTempFont.Size + (7 * Math.Sin(3 * time))));
        }

        private void drawTimer_Tick_1(object sender, EventArgs e)
        {

            time += 0.015;
            Refresh();
        }

        private void updateCityButton_Click(object sender, EventArgs e)
        {
            string url = "http://api.openweathermap.org/data/2.5/forecast/daily?q=" + cityInputTextbox.Text + ",CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0";
            try
            {
                XmlReader reader = XmlReader.Create(url);
                reader.Close();
                Form1.ExtractInfo(cityInputTextbox.Text);
                DisplayCurrent();
            }
            catch { cityInputTextbox.Text = "City not found"; }
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
    }
}
