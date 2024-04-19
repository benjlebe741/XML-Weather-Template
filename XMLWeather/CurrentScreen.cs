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

        //The closer the current min and max temperature gets to COLD_TEMP & HOT_TEMP...
        const int COLD_TEMP = -20;
        const int HOT_TEMP = 40;
        //The more the background color will match the 'coldest' or 'hottest' color value!
        Color minColor, maxColor;
        //How much the opacity of the background colors should change from label to label
        double hueShiftValue = 6;

        //Stores the bouncing Current Temperature's innitial value
        Font defaultTempFont;
        //Time increases each timer tick, and is used for gradually changing the color and size of text in a sin wave pattern
        double time = 1;

        //These hold the min and max temperature that we get from days[0], they will be used for calculations later
        double minTemp;
        double maxTemp;
        //Keeps track of the labels that I want a translucent background on
        Label[] onScreenLabels;
        public CurrentScreen()
        {
            InitializeComponent();

            DisplayCurrent();
            //Store the innitial size and look of the bouncing currentTemp font:
            defaultTempFont = currentTempOutput.Font;
            //All the labels I want a background color on:
            onScreenLabels = new Label[]
            {
                todayLabel, forecastLabel, feelsLikeOutput, humidityOutput, precipitationOutput, cloudsOutput, windSpeedOutput, windDirectionOutput
            };

        }

        Color determineColor(double temperature)
        {
            //If temperature lies beyond the max hot or cold checks, set it as what its closest to
            temperature = (temperature > HOT_TEMP) ? HOT_TEMP : temperature;
            temperature = (temperature < COLD_TEMP) ? COLD_TEMP : temperature;

            //Now find where this temperature lies on the scale from max cold temp to max hot temp... 
            double hotness = ((temperature + Math.Abs(COLD_TEMP)) / (HOT_TEMP + Math.Abs(COLD_TEMP))) + 0.0001;

            //Now affect the color depending on how hot or cold it should be
            int r = (int)((coldColor.R * (1 - hotness)) + (hotColor.R * hotness));
            int g = (int)((coldColor.G * (1 - hotness)) + (hotColor.G * hotness));
            int b = (int)((coldColor.B * (1 - hotness)) + (hotColor.B * hotness));

            //return the color
            Color ghostColor = Color.FromArgb(r, g, b);
            return ghostColor;
        }

        public void DisplayCurrent()
        {
            //Create a copy of the first day of Form1, this is the only day we need to use on CurrentScreen
            Day today = Form1.days[0];

            //Set the min and max temp values which will be used for background color information
            minTemp = Convert.ToDouble(today.tempLow);
            maxTemp = Convert.ToDouble(today.tempHigh);

            //Put all the info in days[0] in the correct spot on the screen. We have already removed decimals on Form1.
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

            //Now using those max and min temperatures get the minimum and maximum background color
            minColor = determineColor(minTemp);
            maxColor = determineColor(maxTemp);

            //Find the appropriate image to display according to the code we have recieved, and display it
            ResourceManager rm = Resources.ResourceManager;
            string pngName = "_" + today.symbol;
            imageLabel.Image = (Image)rm.GetObject(pngName);
        }

        private void CurrentScreen_Paint(object sender, PaintEventArgs e)
        {
            //This block of code cycles smoothly between the Min and Max background color, taken from the temperature today
            double sinValue = Math.Abs(Math.Sin(time)) + 0.00001;
            int r = (int)((minColor.R * (sinValue)) + (maxColor.R * (1 - sinValue)));
            int g = (int)((minColor.G * (sinValue)) + (maxColor.G * (1 - sinValue)));
            int b = (int)((minColor.B * (sinValue)) + (maxColor.B * (1 - sinValue)));
            BackColor = Color.FromArgb(r, g, b);

            //This block of code changes the color of the labels background color, also following a sin wave
            double hueShift = (2 - Math.Sin(2 * time)) * hueShiftValue;
            double opacity = onScreenLabels.Count() * hueShift;
            foreach (Label label in onScreenLabels)
            {
                //The later the labels are in the list, the less opacity their background will have, this is purely decorative
                label.BackColor = Color.FromArgb((int)opacity, 0 + (r / 3), 20 + (g / 3), 130 + (b / 3));
                opacity -= hueShift;
            }

            //This bounces the current temperature in and out along the sin wave
            currentTempOutput.Font = new Font(defaultTempFont.Name, (float)(defaultTempFont.Size + (7 * Math.Sin(3 * time))));
        }

        private void drawTimer_Tick_1(object sender, EventArgs e)
        {
            //Display current time
            timeOutput.Text = DateTime.Now.ToString("dddd\nhh:mm:ss tt");

            //Add to time (how my sin wave decorations work), and refresh to call the paint event
            time += 0.015;
            Refresh();
        }

        private void updateCityButton_Click(object sender, EventArgs e)
        {
            //Check to see if the city name thats given returns an error, if it does: display a message, if it doesn't: extract the new info and display it
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
            //Close this screen and go to the forecast screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
    }
}
