namespace XMLWeather
{
    partial class CurrentScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.drawTimer = new System.Windows.Forms.Timer(this.components);
            this.forecastLabel = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.currentTempOutput = new System.Windows.Forms.Label();
            this.statusOutput = new System.Windows.Forms.Label();
            this.cityOutput = new System.Windows.Forms.Label();
            this.highLowOutput = new System.Windows.Forms.Label();
            this.windSpeedOutput = new System.Windows.Forms.Label();
            this.windDirectionOutput = new System.Windows.Forms.Label();
            this.feelsLikeOutput = new System.Windows.Forms.Label();
            this.humidityOutput = new System.Windows.Forms.Label();
            this.precipitationOutput = new System.Windows.Forms.Label();
            this.cloudsOutput = new System.Windows.Forms.Label();
            this.cityInputTextbox = new System.Windows.Forms.TextBox();
            this.updateCityButton = new System.Windows.Forms.Button();
            this.imageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // drawTimer
            // 
            this.drawTimer.Enabled = true;
            this.drawTimer.Interval = 20;
            this.drawTimer.Tick += new System.EventHandler(this.drawTimer_Tick_1);
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(295, 752);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(207, 82);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // todayLabel
            // 
            this.todayLabel.BackColor = System.Drawing.Color.Transparent;
            this.todayLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayLabel.ForeColor = System.Drawing.Color.White;
            this.todayLabel.Location = new System.Drawing.Point(17, 738);
            this.todayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(253, 108);
            this.todayLabel.TabIndex = 43;
            this.todayLabel.Text = "Today";
            this.todayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentTempOutput
            // 
            this.currentTempOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentTempOutput.Font = new System.Drawing.Font("Microsoft Tai Le", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTempOutput.ForeColor = System.Drawing.Color.White;
            this.currentTempOutput.Location = new System.Drawing.Point(48, 114);
            this.currentTempOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentTempOutput.Name = "currentTempOutput";
            this.currentTempOutput.Size = new System.Drawing.Size(449, 153);
            this.currentTempOutput.TabIndex = 44;
            this.currentTempOutput.Text = "14";
            this.currentTempOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusOutput
            // 
            this.statusOutput.BackColor = System.Drawing.Color.Transparent;
            this.statusOutput.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusOutput.ForeColor = System.Drawing.Color.White;
            this.statusOutput.Location = new System.Drawing.Point(17, 306);
            this.statusOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusOutput.Name = "statusOutput";
            this.statusOutput.Size = new System.Drawing.Size(501, 39);
            this.statusOutput.TabIndex = 45;
            this.statusOutput.Text = "Partly cloudy";
            this.statusOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(31, 27);
            this.cityOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(467, 54);
            this.cityOutput.TabIndex = 46;
            this.cityOutput.Text = "City";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highLowOutput
            // 
            this.highLowOutput.BackColor = System.Drawing.Color.Transparent;
            this.highLowOutput.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highLowOutput.ForeColor = System.Drawing.Color.White;
            this.highLowOutput.Location = new System.Drawing.Point(24, 267);
            this.highLowOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.highLowOutput.Name = "highLowOutput";
            this.highLowOutput.Size = new System.Drawing.Size(495, 39);
            this.highLowOutput.TabIndex = 47;
            this.highLowOutput.Text = "H: 10, L: 20";
            this.highLowOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // windSpeedOutput
            // 
            this.windSpeedOutput.BackColor = System.Drawing.Color.Transparent;
            this.windSpeedOutput.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windSpeedOutput.ForeColor = System.Drawing.Color.White;
            this.windSpeedOutput.Location = new System.Drawing.Point(17, 603);
            this.windSpeedOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.windSpeedOutput.Name = "windSpeedOutput";
            this.windSpeedOutput.Size = new System.Drawing.Size(253, 39);
            this.windSpeedOutput.TabIndex = 50;
            this.windSpeedOutput.Text = "Windspeed at";
            this.windSpeedOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // windDirectionOutput
            // 
            this.windDirectionOutput.BackColor = System.Drawing.Color.Transparent;
            this.windDirectionOutput.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windDirectionOutput.ForeColor = System.Drawing.Color.White;
            this.windDirectionOutput.Location = new System.Drawing.Point(17, 642);
            this.windDirectionOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.windDirectionOutput.Name = "windDirectionOutput";
            this.windDirectionOutput.Size = new System.Drawing.Size(253, 39);
            this.windDirectionOutput.TabIndex = 51;
            this.windDirectionOutput.Text = "Wind Direction";
            this.windDirectionOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // feelsLikeOutput
            // 
            this.feelsLikeOutput.BackColor = System.Drawing.Color.Transparent;
            this.feelsLikeOutput.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feelsLikeOutput.ForeColor = System.Drawing.Color.White;
            this.feelsLikeOutput.Location = new System.Drawing.Point(17, 446);
            this.feelsLikeOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.feelsLikeOutput.Name = "feelsLikeOutput";
            this.feelsLikeOutput.Size = new System.Drawing.Size(253, 39);
            this.feelsLikeOutput.TabIndex = 52;
            this.feelsLikeOutput.Text = "Feels like";
            this.feelsLikeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // humidityOutput
            // 
            this.humidityOutput.BackColor = System.Drawing.Color.Transparent;
            this.humidityOutput.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityOutput.ForeColor = System.Drawing.Color.White;
            this.humidityOutput.Location = new System.Drawing.Point(17, 485);
            this.humidityOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.humidityOutput.Name = "humidityOutput";
            this.humidityOutput.Size = new System.Drawing.Size(253, 39);
            this.humidityOutput.TabIndex = 53;
            this.humidityOutput.Text = "Humidity";
            this.humidityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // precipitationOutput
            // 
            this.precipitationOutput.BackColor = System.Drawing.Color.Transparent;
            this.precipitationOutput.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precipitationOutput.ForeColor = System.Drawing.Color.White;
            this.precipitationOutput.Location = new System.Drawing.Point(17, 524);
            this.precipitationOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.precipitationOutput.Name = "precipitationOutput";
            this.precipitationOutput.Size = new System.Drawing.Size(253, 39);
            this.precipitationOutput.TabIndex = 54;
            this.precipitationOutput.Text = "Precipitation";
            this.precipitationOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cloudsOutput
            // 
            this.cloudsOutput.BackColor = System.Drawing.Color.Transparent;
            this.cloudsOutput.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cloudsOutput.ForeColor = System.Drawing.Color.White;
            this.cloudsOutput.Location = new System.Drawing.Point(17, 564);
            this.cloudsOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cloudsOutput.Name = "cloudsOutput";
            this.cloudsOutput.Size = new System.Drawing.Size(253, 39);
            this.cloudsOutput.TabIndex = 55;
            this.cloudsOutput.Text = "Clouds";
            this.cloudsOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cityInputTextbox
            // 
            this.cityInputTextbox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cityInputTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityInputTextbox.ForeColor = System.Drawing.Color.SlateGray;
            this.cityInputTextbox.Location = new System.Drawing.Point(12, 14);
            this.cityInputTextbox.Name = "cityInputTextbox";
            this.cityInputTextbox.Size = new System.Drawing.Size(164, 22);
            this.cityInputTextbox.TabIndex = 56;
            this.cityInputTextbox.Text = "\"City Name\"";
            this.cityInputTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // updateCityButton
            // 
            this.updateCityButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateCityButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateCityButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCityButton.ForeColor = System.Drawing.Color.SlateGray;
            this.updateCityButton.Location = new System.Drawing.Point(12, 42);
            this.updateCityButton.Name = "updateCityButton";
            this.updateCityButton.Size = new System.Drawing.Size(55, 33);
            this.updateCityButton.TabIndex = 57;
            this.updateCityButton.Text = "Go";
            this.updateCityButton.UseVisualStyleBackColor = false;
            this.updateCityButton.Click += new System.EventHandler(this.updateCityButton_Click);
            // 
            // imageLabel
            // 
            this.imageLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imageLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.imageLabel.Image = global::XMLWeather.Properties.Resources._04n;
            this.imageLabel.Location = new System.Drawing.Point(339, 143);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(98, 85);
            this.imageLabel.TabIndex = 58;
            this.imageLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.Controls.Add(this.imageLabel);
            this.Controls.Add(this.updateCityButton);
            this.Controls.Add(this.cityInputTextbox);
            this.Controls.Add(this.cloudsOutput);
            this.Controls.Add(this.precipitationOutput);
            this.Controls.Add(this.humidityOutput);
            this.Controls.Add(this.feelsLikeOutput);
            this.Controls.Add(this.windDirectionOutput);
            this.Controls.Add(this.windSpeedOutput);
            this.Controls.Add(this.highLowOutput);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.statusOutput);
            this.Controls.Add(this.currentTempOutput);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.forecastLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(541, 898);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CurrentScreen_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer drawTimer;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label currentTempOutput;
        private System.Windows.Forms.Label statusOutput;
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label highLowOutput;
        private System.Windows.Forms.Label windSpeedOutput;
        private System.Windows.Forms.Label windDirectionOutput;
        private System.Windows.Forms.Label feelsLikeOutput;
        private System.Windows.Forms.Label humidityOutput;
        private System.Windows.Forms.Label precipitationOutput;
        private System.Windows.Forms.Label cloudsOutput;
        private System.Windows.Forms.TextBox cityInputTextbox;
        private System.Windows.Forms.Button updateCityButton;
        private System.Windows.Forms.Label imageLabel;
    }
}
