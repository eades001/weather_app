namespace WeatherApp
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.inputValuesGroupBox = new System.Windows.Forms.GroupBox();
            this.conditionsDropDownList = new System.Windows.Forms.ComboBox();
            this.windDropDownList = new System.Windows.Forms.ComboBox();
            this.lowTempDropDownList = new System.Windows.Forms.ComboBox();
            this.highTempDropDownList = new System.Windows.Forms.ComboBox();
            this.postButton = new System.Windows.Forms.Button();
            this.inputSkyConditionLabel = new System.Windows.Forms.Label();
            this.inputWindSpeedLabel = new System.Windows.Forms.Label();
            this.inputLowTempLabel = new System.Windows.Forms.Label();
            this.inputHighTempLabel = new System.Windows.Forms.Label();
            this.forcastGroupBox = new System.Windows.Forms.GroupBox();
            this.windChillValueLabel = new System.Windows.Forms.Label();
            this.windSpeedValueLabel = new System.Windows.Forms.Label();
            this.lowTempValueLabel = new System.Windows.Forms.Label();
            this.highTempValueLabel = new System.Windows.Forms.Label();
            this.skyConditionPictureBox = new System.Windows.Forms.PictureBox();
            this.forcastWindChillLabel = new System.Windows.Forms.Label();
            this.forcastSkyConditionLabel = new System.Windows.Forms.Label();
            this.forcastWindSpeedLabel = new System.Windows.Forms.Label();
            this.forcastLowTempLabel = new System.Windows.Forms.Label();
            this.forcastHighTempLabel = new System.Windows.Forms.Label();
            this.inputValuesGroupBox.SuspendLayout();
            this.forcastGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skyConditionPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Azure;
            this.exitButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.exitButton.Location = new System.Drawing.Point(576, 442);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(109, 41);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // inputValuesGroupBox
            // 
            this.inputValuesGroupBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.inputValuesGroupBox.Controls.Add(this.conditionsDropDownList);
            this.inputValuesGroupBox.Controls.Add(this.windDropDownList);
            this.inputValuesGroupBox.Controls.Add(this.lowTempDropDownList);
            this.inputValuesGroupBox.Controls.Add(this.highTempDropDownList);
            this.inputValuesGroupBox.Controls.Add(this.postButton);
            this.inputValuesGroupBox.Controls.Add(this.inputSkyConditionLabel);
            this.inputValuesGroupBox.Controls.Add(this.inputWindSpeedLabel);
            this.inputValuesGroupBox.Controls.Add(this.inputLowTempLabel);
            this.inputValuesGroupBox.Controls.Add(this.inputHighTempLabel);
            this.inputValuesGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputValuesGroupBox.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputValuesGroupBox.Location = new System.Drawing.Point(34, 27);
            this.inputValuesGroupBox.Name = "inputValuesGroupBox";
            this.inputValuesGroupBox.Size = new System.Drawing.Size(257, 386);
            this.inputValuesGroupBox.TabIndex = 1;
            this.inputValuesGroupBox.TabStop = false;
            this.inputValuesGroupBox.Text = " Input Values ";
            // 
            // conditionsDropDownList
            // 
            this.conditionsDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conditionsDropDownList.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.conditionsDropDownList.FormattingEnabled = true;
            this.conditionsDropDownList.Items.AddRange(new object[] {
            "Clear",
            "Partly Cloudy",
            "Cloudy",
            "Rain"});
            this.conditionsDropDownList.Location = new System.Drawing.Point(137, 236);
            this.conditionsDropDownList.Name = "conditionsDropDownList";
            this.conditionsDropDownList.Size = new System.Drawing.Size(97, 27);
            this.conditionsDropDownList.TabIndex = 8;
            this.conditionsDropDownList.SelectedIndexChanged += new System.EventHandler(this.conditionsDropDownList_SelectedIndexChanged);
            // 
            // windDropDownList
            // 
            this.windDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.windDropDownList.FormattingEnabled = true;
            this.windDropDownList.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.windDropDownList.Location = new System.Drawing.Point(165, 178);
            this.windDropDownList.Name = "windDropDownList";
            this.windDropDownList.Size = new System.Drawing.Size(69, 30);
            this.windDropDownList.TabIndex = 7;
            // 
            // lowTempDropDownList
            // 
            this.lowTempDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lowTempDropDownList.FormattingEnabled = true;
            this.lowTempDropDownList.Items.AddRange(new object[] {
            "35",
            "30",
            "25",
            "20",
            "15",
            "10",
            "5",
            "0",
            "-5",
            "-10",
            "-15"});
            this.lowTempDropDownList.Location = new System.Drawing.Point(165, 115);
            this.lowTempDropDownList.Name = "lowTempDropDownList";
            this.lowTempDropDownList.Size = new System.Drawing.Size(69, 30);
            this.lowTempDropDownList.TabIndex = 6;
            // 
            // highTempDropDownList
            // 
            this.highTempDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.highTempDropDownList.FormattingEnabled = true;
            this.highTempDropDownList.Items.AddRange(new object[] {
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100"});
            this.highTempDropDownList.Location = new System.Drawing.Point(165, 50);
            this.highTempDropDownList.Name = "highTempDropDownList";
            this.highTempDropDownList.Size = new System.Drawing.Size(69, 30);
            this.highTempDropDownList.TabIndex = 5;
            // 
            // postButton
            // 
            this.postButton.BackColor = System.Drawing.Color.Azure;
            this.postButton.Enabled = false;
            this.postButton.Location = new System.Drawing.Point(137, 330);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(97, 34);
            this.postButton.TabIndex = 4;
            this.postButton.Text = "Post";
            this.postButton.UseVisualStyleBackColor = false;
            this.postButton.Click += new System.EventHandler(this.PostButton_Click);
            // 
            // inputSkyConditionLabel
            // 
            this.inputSkyConditionLabel.AutoSize = true;
            this.inputSkyConditionLabel.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputSkyConditionLabel.Location = new System.Drawing.Point(15, 243);
            this.inputSkyConditionLabel.MaximumSize = new System.Drawing.Size(100, 0);
            this.inputSkyConditionLabel.Name = "inputSkyConditionLabel";
            this.inputSkyConditionLabel.Size = new System.Drawing.Size(91, 17);
            this.inputSkyConditionLabel.TabIndex = 3;
            this.inputSkyConditionLabel.Text = "Sky Condition";
            // 
            // inputWindSpeedLabel
            // 
            this.inputWindSpeedLabel.AutoSize = true;
            this.inputWindSpeedLabel.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputWindSpeedLabel.Location = new System.Drawing.Point(15, 185);
            this.inputWindSpeedLabel.MaximumSize = new System.Drawing.Size(100, 0);
            this.inputWindSpeedLabel.Name = "inputWindSpeedLabel";
            this.inputWindSpeedLabel.Size = new System.Drawing.Size(79, 17);
            this.inputWindSpeedLabel.TabIndex = 2;
            this.inputWindSpeedLabel.Text = "Wind Speed";
            // 
            // inputLowTempLabel
            // 
            this.inputLowTempLabel.AutoSize = true;
            this.inputLowTempLabel.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputLowTempLabel.Location = new System.Drawing.Point(15, 111);
            this.inputLowTempLabel.MaximumSize = new System.Drawing.Size(100, 0);
            this.inputLowTempLabel.Name = "inputLowTempLabel";
            this.inputLowTempLabel.Size = new System.Drawing.Size(97, 34);
            this.inputLowTempLabel.TabIndex = 1;
            this.inputLowTempLabel.Text = "Predicted Low Temperature";
            // 
            // inputHighTempLabel
            // 
            this.inputHighTempLabel.AutoSize = true;
            this.inputHighTempLabel.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputHighTempLabel.Location = new System.Drawing.Point(15, 50);
            this.inputHighTempLabel.MaximumSize = new System.Drawing.Size(100, 0);
            this.inputHighTempLabel.Name = "inputHighTempLabel";
            this.inputHighTempLabel.Size = new System.Drawing.Size(99, 34);
            this.inputHighTempLabel.TabIndex = 0;
            this.inputHighTempLabel.Text = "Predicted High Temperature";
            // 
            // forcastGroupBox
            // 
            this.forcastGroupBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.forcastGroupBox.Controls.Add(this.windChillValueLabel);
            this.forcastGroupBox.Controls.Add(this.windSpeedValueLabel);
            this.forcastGroupBox.Controls.Add(this.lowTempValueLabel);
            this.forcastGroupBox.Controls.Add(this.highTempValueLabel);
            this.forcastGroupBox.Controls.Add(this.skyConditionPictureBox);
            this.forcastGroupBox.Controls.Add(this.forcastWindChillLabel);
            this.forcastGroupBox.Controls.Add(this.forcastSkyConditionLabel);
            this.forcastGroupBox.Controls.Add(this.forcastWindSpeedLabel);
            this.forcastGroupBox.Controls.Add(this.forcastLowTempLabel);
            this.forcastGroupBox.Controls.Add(this.forcastHighTempLabel);
            this.forcastGroupBox.Font = new System.Drawing.Font("Candara", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.forcastGroupBox.Location = new System.Drawing.Point(327, 27);
            this.forcastGroupBox.Name = "forcastGroupBox";
            this.forcastGroupBox.Size = new System.Drawing.Size(358, 386);
            this.forcastGroupBox.TabIndex = 2;
            this.forcastGroupBox.TabStop = false;
            this.forcastGroupBox.Text = "TODAY\'S FORCAST";
            // 
            // windChillValueLabel
            // 
            this.windChillValueLabel.AutoSize = true;
            this.windChillValueLabel.Font = new System.Drawing.Font("Candara", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.windChillValueLabel.Location = new System.Drawing.Point(241, 290);
            this.windChillValueLabel.Name = "windChillValueLabel";
            this.windChillValueLabel.Size = new System.Drawing.Size(0, 46);
            this.windChillValueLabel.TabIndex = 9;
            // 
            // windSpeedValueLabel
            // 
            this.windSpeedValueLabel.AutoSize = true;
            this.windSpeedValueLabel.Font = new System.Drawing.Font("Candara", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.windSpeedValueLabel.Location = new System.Drawing.Point(71, 290);
            this.windSpeedValueLabel.Name = "windSpeedValueLabel";
            this.windSpeedValueLabel.Size = new System.Drawing.Size(0, 46);
            this.windSpeedValueLabel.TabIndex = 8;
            // 
            // lowTempValueLabel
            // 
            this.lowTempValueLabel.AutoSize = true;
            this.lowTempValueLabel.Font = new System.Drawing.Font("Candara", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lowTempValueLabel.Location = new System.Drawing.Point(71, 185);
            this.lowTempValueLabel.Name = "lowTempValueLabel";
            this.lowTempValueLabel.Size = new System.Drawing.Size(0, 46);
            this.lowTempValueLabel.TabIndex = 7;
            // 
            // highTempValueLabel
            // 
            this.highTempValueLabel.AutoSize = true;
            this.highTempValueLabel.Font = new System.Drawing.Font("Candara", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.highTempValueLabel.Location = new System.Drawing.Point(71, 88);
            this.highTempValueLabel.Name = "highTempValueLabel";
            this.highTempValueLabel.Size = new System.Drawing.Size(0, 46);
            this.highTempValueLabel.TabIndex = 6;
            // 
            // skyConditionPictureBox
            // 
            this.skyConditionPictureBox.Location = new System.Drawing.Point(203, 31);
            this.skyConditionPictureBox.Name = "skyConditionPictureBox";
            this.skyConditionPictureBox.Size = new System.Drawing.Size(130, 115);
            this.skyConditionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.skyConditionPictureBox.TabIndex = 5;
            this.skyConditionPictureBox.TabStop = false;
            // 
            // forcastWindChillLabel
            // 
            this.forcastWindChillLabel.AutoSize = true;
            this.forcastWindChillLabel.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.forcastWindChillLabel.Location = new System.Drawing.Point(225, 258);
            this.forcastWindChillLabel.Name = "forcastWindChillLabel";
            this.forcastWindChillLabel.Size = new System.Drawing.Size(86, 22);
            this.forcastWindChillLabel.TabIndex = 4;
            this.forcastWindChillLabel.Text = "Wind Chill";
            // 
            // forcastSkyConditionLabel
            // 
            this.forcastSkyConditionLabel.AutoSize = true;
            this.forcastSkyConditionLabel.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.forcastSkyConditionLabel.Location = new System.Drawing.Point(210, 157);
            this.forcastSkyConditionLabel.Name = "forcastSkyConditionLabel";
            this.forcastSkyConditionLabel.Size = new System.Drawing.Size(114, 22);
            this.forcastSkyConditionLabel.TabIndex = 3;
            this.forcastSkyConditionLabel.Text = "Sky Condition";
            // 
            // forcastWindSpeedLabel
            // 
            this.forcastWindSpeedLabel.AutoSize = true;
            this.forcastWindSpeedLabel.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.forcastWindSpeedLabel.Location = new System.Drawing.Point(43, 258);
            this.forcastWindSpeedLabel.Name = "forcastWindSpeedLabel";
            this.forcastWindSpeedLabel.Size = new System.Drawing.Size(101, 22);
            this.forcastWindSpeedLabel.TabIndex = 2;
            this.forcastWindSpeedLabel.Text = "Wind Speed";
            // 
            // forcastLowTempLabel
            // 
            this.forcastLowTempLabel.AutoSize = true;
            this.forcastLowTempLabel.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.forcastLowTempLabel.Location = new System.Drawing.Point(25, 157);
            this.forcastLowTempLabel.Name = "forcastLowTempLabel";
            this.forcastLowTempLabel.Size = new System.Drawing.Size(144, 22);
            this.forcastLowTempLabel.TabIndex = 1;
            this.forcastLowTempLabel.Text = "Low Temperature";
            // 
            // forcastHighTempLabel
            // 
            this.forcastHighTempLabel.AutoSize = true;
            this.forcastHighTempLabel.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.forcastHighTempLabel.Location = new System.Drawing.Point(25, 58);
            this.forcastHighTempLabel.Name = "forcastHighTempLabel";
            this.forcastHighTempLabel.Size = new System.Drawing.Size(147, 22);
            this.forcastHighTempLabel.TabIndex = 0;
            this.forcastHighTempLabel.Text = "High Temperature";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(714, 512);
            this.Controls.Add(this.forcastGroupBox);
            this.Controls.Add(this.inputValuesGroupBox);
            this.Controls.Add(this.exitButton);
            this.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Weather Today";
            this.inputValuesGroupBox.ResumeLayout(false);
            this.inputValuesGroupBox.PerformLayout();
            this.forcastGroupBox.ResumeLayout(false);
            this.forcastGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skyConditionPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox inputValuesGroupBox;
        private System.Windows.Forms.GroupBox forcastGroupBox;
        private System.Windows.Forms.Label inputSkyConditionLabel;
        private System.Windows.Forms.Label inputWindSpeedLabel;
        private System.Windows.Forms.Label inputLowTempLabel;
        private System.Windows.Forms.Label inputHighTempLabel;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.ComboBox highTempDropDownList;
        private System.Windows.Forms.ComboBox conditionsDropDownList;
        private System.Windows.Forms.ComboBox windDropDownList;
        private System.Windows.Forms.ComboBox lowTempDropDownList;
        private System.Windows.Forms.PictureBox skyConditionPictureBox;
        private System.Windows.Forms.Label forcastWindChillLabel;
        private System.Windows.Forms.Label forcastSkyConditionLabel;
        private System.Windows.Forms.Label forcastWindSpeedLabel;
        private System.Windows.Forms.Label forcastLowTempLabel;
        private System.Windows.Forms.Label forcastHighTempLabel;
        private System.Windows.Forms.Label windSpeedValueLabel;
        private System.Windows.Forms.Label lowTempValueLabel;
        private System.Windows.Forms.Label highTempValueLabel;
        private System.Windows.Forms.Label windChillValueLabel;
    }
}

