namespace XMLWeather
{
    partial class ForecastScreen
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
            this.day1Output = new System.Windows.Forms.Label();
            this.HL1output = new System.Windows.Forms.Label();
            this.cityOutput = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.status1Output = new System.Windows.Forms.Label();
            this.day2Output = new System.Windows.Forms.Label();
            this.HL2output = new System.Windows.Forms.Label();
            this.status2Output = new System.Windows.Forms.Label();
            this.day4Output = new System.Windows.Forms.Label();
            this.HL4output = new System.Windows.Forms.Label();
            this.status4Output = new System.Windows.Forms.Label();
            this.day3Output = new System.Windows.Forms.Label();
            this.HL3output = new System.Windows.Forms.Label();
            this.status3Output = new System.Windows.Forms.Label();
            this.day6Output = new System.Windows.Forms.Label();
            this.HL6output = new System.Windows.Forms.Label();
            this.status6Output = new System.Windows.Forms.Label();
            this.day5Output = new System.Windows.Forms.Label();
            this.HL5output = new System.Windows.Forms.Label();
            this.status5Output = new System.Windows.Forms.Label();
            this.day7Output = new System.Windows.Forms.Label();
            this.HL7output = new System.Windows.Forms.Label();
            this.status7Output = new System.Windows.Forms.Label();
            this.image1Label = new System.Windows.Forms.Label();
            this.image2Label = new System.Windows.Forms.Label();
            this.image3Label = new System.Windows.Forms.Label();
            this.image4Label = new System.Windows.Forms.Label();
            this.image5Label = new System.Windows.Forms.Label();
            this.image6Label = new System.Windows.Forms.Label();
            this.image7Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // day1Output
            // 
            this.day1Output.BackColor = System.Drawing.Color.Transparent;
            this.day1Output.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day1Output.ForeColor = System.Drawing.Color.White;
            this.day1Output.Location = new System.Drawing.Point(20, 143);
            this.day1Output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.day1Output.Name = "day1Output";
            this.day1Output.Size = new System.Drawing.Size(219, 39);
            this.day1Output.TabIndex = 64;
            this.day1Output.Text = "Monday";
            this.day1Output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.day1Output.Click += new System.EventHandler(this.feelsLikeOutput_Click);
            // 
            // HL1output
            // 
            this.HL1output.BackColor = System.Drawing.Color.Transparent;
            this.HL1output.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HL1output.ForeColor = System.Drawing.Color.White;
            this.HL1output.Location = new System.Drawing.Point(247, 142);
            this.HL1output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HL1output.Name = "HL1output";
            this.HL1output.Size = new System.Drawing.Size(204, 39);
            this.HL1output.TabIndex = 61;
            this.HL1output.Text = "H: 10, L: 20";
            this.HL1output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HL1output.Click += new System.EventHandler(this.label1_Click);
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
            this.cityOutput.TabIndex = 60;
            this.cityOutput.Text = "City";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // todayLabel
            // 
            this.todayLabel.BackColor = System.Drawing.Color.Transparent;
            this.todayLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayLabel.ForeColor = System.Drawing.Color.White;
            this.todayLabel.Location = new System.Drawing.Point(40, 752);
            this.todayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(207, 82);
            this.todayLabel.TabIndex = 56;
            this.todayLabel.Tag = "";
            this.todayLabel.Text = "Today";
            this.todayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.todayLabel.Click += new System.EventHandler(this.todayLabel_Click);
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(272, 738);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(253, 108);
            this.forecastLabel.TabIndex = 68;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // status1Output
            // 
            this.status1Output.BackColor = System.Drawing.Color.Transparent;
            this.status1Output.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status1Output.ForeColor = System.Drawing.Color.White;
            this.status1Output.Location = new System.Drawing.Point(247, 181);
            this.status1Output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status1Output.Name = "status1Output";
            this.status1Output.Size = new System.Drawing.Size(204, 39);
            this.status1Output.TabIndex = 59;
            this.status1Output.Text = "Partly cloudy";
            this.status1Output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.status1Output.Click += new System.EventHandler(this.statusOutput_Click);
            // 
            // day2Output
            // 
            this.day2Output.BackColor = System.Drawing.Color.Transparent;
            this.day2Output.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day2Output.ForeColor = System.Drawing.Color.White;
            this.day2Output.Location = new System.Drawing.Point(20, 226);
            this.day2Output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.day2Output.Name = "day2Output";
            this.day2Output.Size = new System.Drawing.Size(219, 39);
            this.day2Output.TabIndex = 71;
            this.day2Output.Text = "Monday";
            this.day2Output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.day2Output.Click += new System.EventHandler(this.day2Output_Click);
            // 
            // HL2output
            // 
            this.HL2output.BackColor = System.Drawing.Color.Transparent;
            this.HL2output.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HL2output.ForeColor = System.Drawing.Color.White;
            this.HL2output.Location = new System.Drawing.Point(247, 226);
            this.HL2output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HL2output.Name = "HL2output";
            this.HL2output.Size = new System.Drawing.Size(204, 39);
            this.HL2output.TabIndex = 70;
            this.HL2output.Text = "H: 10, L: 20";
            this.HL2output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HL2output.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // status2Output
            // 
            this.status2Output.BackColor = System.Drawing.Color.Transparent;
            this.status2Output.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status2Output.ForeColor = System.Drawing.Color.White;
            this.status2Output.Location = new System.Drawing.Point(247, 265);
            this.status2Output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status2Output.Name = "status2Output";
            this.status2Output.Size = new System.Drawing.Size(204, 39);
            this.status2Output.TabIndex = 69;
            this.status2Output.Text = "Partly cloudy";
            this.status2Output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.status2Output.Click += new System.EventHandler(this.label4_Click);
            // 
            // day4Output
            // 
            this.day4Output.BackColor = System.Drawing.Color.Transparent;
            this.day4Output.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day4Output.ForeColor = System.Drawing.Color.White;
            this.day4Output.Location = new System.Drawing.Point(21, 396);
            this.day4Output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.day4Output.Name = "day4Output";
            this.day4Output.Size = new System.Drawing.Size(218, 39);
            this.day4Output.TabIndex = 77;
            this.day4Output.Text = "Monday";
            this.day4Output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.day4Output.Click += new System.EventHandler(this.day4Output_Click);
            // 
            // HL4output
            // 
            this.HL4output.BackColor = System.Drawing.Color.Transparent;
            this.HL4output.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HL4output.ForeColor = System.Drawing.Color.White;
            this.HL4output.Location = new System.Drawing.Point(247, 396);
            this.HL4output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HL4output.Name = "HL4output";
            this.HL4output.Size = new System.Drawing.Size(204, 39);
            this.HL4output.TabIndex = 76;
            this.HL4output.Text = "H: 10, L: 20";
            this.HL4output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HL4output.Click += new System.EventHandler(this.label6_Click);
            // 
            // status4Output
            // 
            this.status4Output.BackColor = System.Drawing.Color.Transparent;
            this.status4Output.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status4Output.ForeColor = System.Drawing.Color.White;
            this.status4Output.Location = new System.Drawing.Point(247, 435);
            this.status4Output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status4Output.Name = "status4Output";
            this.status4Output.Size = new System.Drawing.Size(204, 39);
            this.status4Output.TabIndex = 75;
            this.status4Output.Text = "Partly cloudy";
            this.status4Output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.status4Output.Click += new System.EventHandler(this.label7_Click);
            // 
            // day3Output
            // 
            this.day3Output.BackColor = System.Drawing.Color.Transparent;
            this.day3Output.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day3Output.ForeColor = System.Drawing.Color.White;
            this.day3Output.Location = new System.Drawing.Point(21, 314);
            this.day3Output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.day3Output.Name = "day3Output";
            this.day3Output.Size = new System.Drawing.Size(218, 39);
            this.day3Output.TabIndex = 74;
            this.day3Output.Text = "Monday";
            this.day3Output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.day3Output.Click += new System.EventHandler(this.day3Output_Click);
            // 
            // HL3output
            // 
            this.HL3output.BackColor = System.Drawing.Color.Transparent;
            this.HL3output.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HL3output.ForeColor = System.Drawing.Color.White;
            this.HL3output.Location = new System.Drawing.Point(247, 314);
            this.HL3output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HL3output.Name = "HL3output";
            this.HL3output.Size = new System.Drawing.Size(204, 39);
            this.HL3output.TabIndex = 73;
            this.HL3output.Text = "H: 10, L: 20";
            this.HL3output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HL3output.Click += new System.EventHandler(this.label9_Click);
            // 
            // status3Output
            // 
            this.status3Output.BackColor = System.Drawing.Color.Transparent;
            this.status3Output.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status3Output.ForeColor = System.Drawing.Color.White;
            this.status3Output.Location = new System.Drawing.Point(247, 352);
            this.status3Output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status3Output.Name = "status3Output";
            this.status3Output.Size = new System.Drawing.Size(204, 39);
            this.status3Output.TabIndex = 72;
            this.status3Output.Text = "Partly cloudy";
            this.status3Output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.status3Output.Click += new System.EventHandler(this.label10_Click);
            // 
            // day6Output
            // 
            this.day6Output.BackColor = System.Drawing.Color.Transparent;
            this.day6Output.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day6Output.ForeColor = System.Drawing.Color.White;
            this.day6Output.Location = new System.Drawing.Point(20, 551);
            this.day6Output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.day6Output.Name = "day6Output";
            this.day6Output.Size = new System.Drawing.Size(219, 39);
            this.day6Output.TabIndex = 83;
            this.day6Output.Text = "Monday";
            this.day6Output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.day6Output.Click += new System.EventHandler(this.day6Output_Click);
            // 
            // HL6output
            // 
            this.HL6output.BackColor = System.Drawing.Color.Transparent;
            this.HL6output.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HL6output.ForeColor = System.Drawing.Color.White;
            this.HL6output.Location = new System.Drawing.Point(247, 551);
            this.HL6output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HL6output.Name = "HL6output";
            this.HL6output.Size = new System.Drawing.Size(204, 39);
            this.HL6output.TabIndex = 82;
            this.HL6output.Text = "H: 10, L: 20";
            this.HL6output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HL6output.Click += new System.EventHandler(this.label12_Click);
            // 
            // status6Output
            // 
            this.status6Output.BackColor = System.Drawing.Color.Transparent;
            this.status6Output.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status6Output.ForeColor = System.Drawing.Color.White;
            this.status6Output.Location = new System.Drawing.Point(247, 590);
            this.status6Output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status6Output.Name = "status6Output";
            this.status6Output.Size = new System.Drawing.Size(204, 39);
            this.status6Output.TabIndex = 81;
            this.status6Output.Text = "Partly cloudy";
            this.status6Output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.status6Output.Click += new System.EventHandler(this.label13_Click);
            // 
            // day5Output
            // 
            this.day5Output.BackColor = System.Drawing.Color.Transparent;
            this.day5Output.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day5Output.ForeColor = System.Drawing.Color.White;
            this.day5Output.Location = new System.Drawing.Point(21, 475);
            this.day5Output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.day5Output.Name = "day5Output";
            this.day5Output.Size = new System.Drawing.Size(218, 39);
            this.day5Output.TabIndex = 80;
            this.day5Output.Text = "Monday";
            this.day5Output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.day5Output.Click += new System.EventHandler(this.day5Output_Click);
            // 
            // HL5output
            // 
            this.HL5output.BackColor = System.Drawing.Color.Transparent;
            this.HL5output.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HL5output.ForeColor = System.Drawing.Color.White;
            this.HL5output.Location = new System.Drawing.Point(247, 475);
            this.HL5output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HL5output.Name = "HL5output";
            this.HL5output.Size = new System.Drawing.Size(204, 39);
            this.HL5output.TabIndex = 79;
            this.HL5output.Text = "H: 10, L: 20";
            this.HL5output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HL5output.Click += new System.EventHandler(this.label15_Click);
            // 
            // status5Output
            // 
            this.status5Output.BackColor = System.Drawing.Color.Transparent;
            this.status5Output.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status5Output.ForeColor = System.Drawing.Color.White;
            this.status5Output.Location = new System.Drawing.Point(247, 513);
            this.status5Output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status5Output.Name = "status5Output";
            this.status5Output.Size = new System.Drawing.Size(204, 39);
            this.status5Output.TabIndex = 78;
            this.status5Output.Text = "Partly cloudy";
            this.status5Output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.status5Output.Click += new System.EventHandler(this.label16_Click);
            // 
            // day7Output
            // 
            this.day7Output.BackColor = System.Drawing.Color.Transparent;
            this.day7Output.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day7Output.ForeColor = System.Drawing.Color.White;
            this.day7Output.Location = new System.Drawing.Point(20, 636);
            this.day7Output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.day7Output.Name = "day7Output";
            this.day7Output.Size = new System.Drawing.Size(219, 39);
            this.day7Output.TabIndex = 86;
            this.day7Output.Text = "Monday";
            this.day7Output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.day7Output.Click += new System.EventHandler(this.day7Output_Click);
            // 
            // HL7output
            // 
            this.HL7output.BackColor = System.Drawing.Color.Transparent;
            this.HL7output.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HL7output.ForeColor = System.Drawing.Color.White;
            this.HL7output.Location = new System.Drawing.Point(247, 636);
            this.HL7output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HL7output.Name = "HL7output";
            this.HL7output.Size = new System.Drawing.Size(204, 39);
            this.HL7output.TabIndex = 85;
            this.HL7output.Text = "H: 10, L: 20";
            this.HL7output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HL7output.Click += new System.EventHandler(this.label18_Click);
            // 
            // status7Output
            // 
            this.status7Output.BackColor = System.Drawing.Color.Transparent;
            this.status7Output.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status7Output.ForeColor = System.Drawing.Color.White;
            this.status7Output.Location = new System.Drawing.Point(247, 675);
            this.status7Output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status7Output.Name = "status7Output";
            this.status7Output.Size = new System.Drawing.Size(204, 39);
            this.status7Output.TabIndex = 84;
            this.status7Output.Text = "Partly cloudy";
            this.status7Output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.status7Output.Click += new System.EventHandler(this.label19_Click);
            // 
            // image1Label
            // 
            this.image1Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.image1Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.image1Label.Image = global::XMLWeather.Properties.Resources._04n;
            this.image1Label.Location = new System.Drawing.Point(419, 136);
            this.image1Label.Name = "image1Label";
            this.image1Label.Size = new System.Drawing.Size(101, 78);
            this.image1Label.TabIndex = 87;
            // 
            // image2Label
            // 
            this.image2Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.image2Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.image2Label.Image = global::XMLWeather.Properties.Resources._04n;
            this.image2Label.Location = new System.Drawing.Point(416, 214);
            this.image2Label.Name = "image2Label";
            this.image2Label.Size = new System.Drawing.Size(105, 78);
            this.image2Label.TabIndex = 88;
            // 
            // image3Label
            // 
            this.image3Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.image3Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.image3Label.Image = global::XMLWeather.Properties.Resources._04n;
            this.image3Label.Location = new System.Drawing.Point(419, 292);
            this.image3Label.Name = "image3Label";
            this.image3Label.Size = new System.Drawing.Size(103, 78);
            this.image3Label.TabIndex = 89;
            // 
            // image4Label
            // 
            this.image4Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.image4Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.image4Label.Image = global::XMLWeather.Properties.Resources._04n;
            this.image4Label.Location = new System.Drawing.Point(419, 370);
            this.image4Label.Name = "image4Label";
            this.image4Label.Size = new System.Drawing.Size(103, 78);
            this.image4Label.TabIndex = 90;
            // 
            // image5Label
            // 
            this.image5Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.image5Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.image5Label.Image = global::XMLWeather.Properties.Resources._04n;
            this.image5Label.Location = new System.Drawing.Point(419, 448);
            this.image5Label.Name = "image5Label";
            this.image5Label.Size = new System.Drawing.Size(103, 78);
            this.image5Label.TabIndex = 91;
            // 
            // image6Label
            // 
            this.image6Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.image6Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.image6Label.Image = global::XMLWeather.Properties.Resources._04n;
            this.image6Label.Location = new System.Drawing.Point(419, 526);
            this.image6Label.Name = "image6Label";
            this.image6Label.Size = new System.Drawing.Size(103, 78);
            this.image6Label.TabIndex = 92;
            // 
            // image7Label
            // 
            this.image7Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.image7Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.image7Label.Image = global::XMLWeather.Properties.Resources._04n;
            this.image7Label.Location = new System.Drawing.Point(419, 613);
            this.image7Label.Name = "image7Label";
            this.image7Label.Size = new System.Drawing.Size(103, 78);
            this.image7Label.TabIndex = 93;
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.Controls.Add(this.image7Label);
            this.Controls.Add(this.image6Label);
            this.Controls.Add(this.image5Label);
            this.Controls.Add(this.image4Label);
            this.Controls.Add(this.image3Label);
            this.Controls.Add(this.image2Label);
            this.Controls.Add(this.image1Label);
            this.Controls.Add(this.day7Output);
            this.Controls.Add(this.HL7output);
            this.Controls.Add(this.status7Output);
            this.Controls.Add(this.day6Output);
            this.Controls.Add(this.HL6output);
            this.Controls.Add(this.status6Output);
            this.Controls.Add(this.day5Output);
            this.Controls.Add(this.HL5output);
            this.Controls.Add(this.status5Output);
            this.Controls.Add(this.day4Output);
            this.Controls.Add(this.HL4output);
            this.Controls.Add(this.status4Output);
            this.Controls.Add(this.day3Output);
            this.Controls.Add(this.HL3output);
            this.Controls.Add(this.status3Output);
            this.Controls.Add(this.day2Output);
            this.Controls.Add(this.HL2output);
            this.Controls.Add(this.status2Output);
            this.Controls.Add(this.day1Output);
            this.Controls.Add(this.HL1output);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.status1Output);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.todayLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(541, 898);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label day1Output;
        private System.Windows.Forms.Label HL1output;
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label status1Output;
        private System.Windows.Forms.Label day2Output;
        private System.Windows.Forms.Label HL2output;
        private System.Windows.Forms.Label status2Output;
        private System.Windows.Forms.Label day4Output;
        private System.Windows.Forms.Label HL4output;
        private System.Windows.Forms.Label status4Output;
        private System.Windows.Forms.Label day3Output;
        private System.Windows.Forms.Label HL3output;
        private System.Windows.Forms.Label status3Output;
        private System.Windows.Forms.Label day6Output;
        private System.Windows.Forms.Label HL6output;
        private System.Windows.Forms.Label status6Output;
        private System.Windows.Forms.Label day5Output;
        private System.Windows.Forms.Label HL5output;
        private System.Windows.Forms.Label status5Output;
        private System.Windows.Forms.Label day7Output;
        private System.Windows.Forms.Label HL7output;
        private System.Windows.Forms.Label status7Output;
        private System.Windows.Forms.Label image1Label;
        private System.Windows.Forms.Label image2Label;
        private System.Windows.Forms.Label image3Label;
        private System.Windows.Forms.Label image4Label;
        private System.Windows.Forms.Label image5Label;
        private System.Windows.Forms.Label image6Label;
        private System.Windows.Forms.Label image7Label;
    }
}
