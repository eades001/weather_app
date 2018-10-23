using System;
using System.Drawing;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PostButton_Click(object sender, EventArgs e)
        {
            // Get the dropdown values
            object highTemp = highTempDropDownList.SelectedItem;
            object lowTemp = lowTempDropDownList.SelectedItem;
            object windSpeed = windDropDownList.SelectedItem;
            object skyCondition = conditionsDropDownList.SelectedItem;

            // Create a weather object
            Weather weather = new Weather();

            // Set weather values from dropdown selections
            weather.highTemperature = Convert.ToInt16(highTemp);
            weather.lowTemperature = Convert.ToInt16(lowTemp);
            weather.windSpeed = Convert.ToInt16(windSpeed);
            weather.skyCondition = Convert.ToString(skyCondition);

            // Get the wind chill
            int windChill = weather.WindChill();
            string conditionImageUrl = weather.SkyConditionFile();

            // Display the results in the forcast window
            highTempValueLabel.Text = highTemp.ToString();
            lowTempValueLabel.Text = lowTemp.ToString();
            windSpeedValueLabel.Text = windSpeed.ToString();
            windChillValueLabel.Text = windChill.ToString();
            skyConditionPictureBox.ImageLocation = conditionImageUrl;
        }

        private void conditionsDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            postButton.Enabled = true;
        }
    }
}