using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.days[0].location;

            tempOutput.Text = Math.Round(Convert.ToDouble(Form1.days[0].currentTemp)) + "°C";

            //display day low temp
            minOutput.Text = Math.Round(Convert.ToDouble(Form1.days[0].tempLow)) + "°C";


            //display day high temp
            maxOutput.Text = Math.Round(Convert.ToDouble(Form1.days[0].tempHigh)) + "°C";

            conditionLabel.Text = Form1.days[0].condition;

            dateOutput.Text = Form1.days[0].date;

            if (Form1.days[0].condition == "clear sky")
            {
                conditionOutputLabel.Image = Properties.Resources.sunny;
                this.BackgroundImage = Properties.Resources.sunnyBackround;
            }
            if (Form1.days[0].condition == "scattered clouds" || Form1.days[0].condition == "broken clouds"
                || Form1.days[0].condition == "overcast" || Form1.days[0].condition == "overcast clouds")
            {
                conditionOutputLabel.Image = Properties.Resources.lessCloudy;
            }
            if (Form1.days[0].condition == "few clouds")
            {
                conditionOutputLabel.Image = Properties.Resources.cloudy;
            }
            if (Form1.days[0].condition == "light rain" || Form1.days[0].condition == "moderate rain" || Form1.days[0].condition == "light shower")
            {
                conditionOutputLabel.Image = Properties.Resources.rain;
            }
            if (Form1.days[0].condition == "rain" || Form1.days[0].condition == "shower rain")
            {
                conditionOutputLabel.Image = Properties.Resources.rain;
            }
            if (Form1.days[0].condition == "thunderstorm")
            {
                conditionOutputLabel.Image = Properties.Resources.strom;
            }

            if (Form1.days[0].condition == "snow" || Form1.days[0].condition == "light snow")
            {
                conditionOutputLabel.Image = Properties.Resources.snow;
            }

            if (Form1.days[0].condition == "snow" || Form1.days[0].condition == "light snow")
            {
                this.BackgroundImage = Properties.Resources.snowBackround;
            }
            if (Form1.days[0].condition == "light rain" || Form1.days[0].condition == "moderate rain" || Form1.days[0].condition == "light shower" || Form1.days[0].condition == "rain" || Form1.days[0].condition == "shower rain" || Form1.days[0].condition == "thunderstorm")
            {
                this.BackgroundImage = Properties.Resources.rainbackround;
            }
            if (Form1.days[0].condition == "scattered clouds" || Form1.days[0].condition == "broken clouds"
                || Form1.days[0].condition == "overcast" || Form1.days[0].condition == "overcast clouds" || Form1.days[0].condition == "few clouds")
            {
                this.BackgroundImage = Properties.Resources.cloudBackround;
            }

        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

         
    }
}

