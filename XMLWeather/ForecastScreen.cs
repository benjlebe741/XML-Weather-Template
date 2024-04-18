using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Resources;
using XMLWeather.Properties;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        double hueShift = 6;
        Label[] infoLabels;
        Label[] imageLabels;
        public ForecastScreen()
        {
            InitializeComponent();
            DisplayForecast();

            Label[] onScreenLabels = new Label[]
            {
               forecastLabel, todayLabel, day1Output, day2Output, day3Output, day4Output, day5Output, day6Output, day7Output
            };
            double opacity = onScreenLabels.Count() * hueShift;
            foreach (Label label in onScreenLabels)
            {
                label.BackColor = Color.FromArgb((int)opacity, 0, 20, 130);
                opacity -= hueShift;
            }

        }

        public void DisplayForecast()
        {

            infoLabels = new Label[]
            {
            cityOutput,
            day1Output,day2Output, day3Output, day4Output, day5Output,day6Output, day7Output,
            HL1Output,HL2Output,HL3Output,HL4Output,HL5Output,HL6Output,HL7Output,
            status1Output,status2Output,status3Output,status4Output,status5Output,status6Output,status7Output
            };

            string[] info = new string[]
            {
                Form1.days[0].location,
                Form1.days[0].date, Form1.days[1].date, Form1.days[2].date, Form1.days[3].date, Form1.days[4].date, Form1.days[5].date, Form1.days[6].date,
                $"H: {Form1.days[0].tempHigh}°, L: {Form1.days[0].tempLow}°", $"H: {Form1.days[1].tempHigh}°, L: {Form1.days[1].tempLow}°", $"H: {Form1.days[2].tempHigh}°, L: {Form1.days[2].tempLow}°", $"H: {Form1.days[3].tempHigh}°, L: {Form1.days[3].tempLow}°", $"H: {Form1.days[4].tempHigh}°, L: {Form1.days[4].tempLow}°", $"H: {Form1.days[5].tempHigh}°, L: {Form1.days[5].tempLow}°", $"H: {Form1.days[6].tempHigh}°, L: {Form1.days[6].tempLow}°",
                Form1.days[0].condition, Form1.days[1].condition, Form1.days[2].condition, Form1.days[3].condition, Form1.days[4].condition, Form1.days[5].condition, Form1.days[6].condition,
            };

            for (int i = 0; i < info.Count(); i++)
            {
                infoLabels[i].Text = info[i];
            }

            imageLabels = new Label[]
            {
            image1Label, image2Label, image3Label, image4Label, image5Label, image6Label, image7Label
            };

            ResourceManager rm = Resources.ResourceManager;
            for (int i = 0; i < imageLabels.Count(); i++)
            {
                string pngName = "_" + Form1.days[i].symbol;
                imageLabels[i].Image = (Image)rm.GetObject(pngName);
            }


        }

        private void todayLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
