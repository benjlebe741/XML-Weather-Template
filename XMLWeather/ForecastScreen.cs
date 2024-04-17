using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        double hueShift = 6;
        Label[] infoLabels;
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
            HL1output,HL2output,HL3output,HL4output,HL5output,HL6output,HL7output,
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
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void todayLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        #region FIND OUT HOW TO REMOVE
        private void feelsLikeOutput_Click(object sender, EventArgs e)
        {

        }

        private void day7Output_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void day6Output_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void day5Output_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void day4Output_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void day3Output_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void day2Output_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void statusOutput_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
