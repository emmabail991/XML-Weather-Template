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
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            //display date of weather
            dateOutput1.Text = Form1.days[1].date;

            //display day low temp
            minTemp1.Text = Math.Round(Convert.ToDouble(Form1.days[1].tempLow)) + "°C";

            //display day high temp
            maxTemp1.Text = Math.Round(Convert.ToDouble(Form1.days[1].tempHigh)) + "°C";

            if (Form1.days[0].condition == "clear sky")
            {
                icon1.Image = Properties.Resources.sunny;
                this.BackgroundImage = Properties.Resources.sunnyBackround;
            }
            if (Form1.days[0].condition == "scattered clouds" || Form1.days[1].condition == "broken clouds"
               || Form1.days[0].condition == "overcast" || Form1.days[1].condition == "overcast clouds")
            {
                icon1.Image = Properties.Resources.lessCloudy;
            }
            if (Form1.days[0].condition == "few clouds")
            {
                icon1.Image = Properties.Resources.cloudy;
            }
            if (Form1.days[0].condition == "light rain" || Form1.days[1].condition == "moderate rain" || Form1.days[0].condition == "light shower")
            {
                icon1.Image = Properties.Resources.rain;
            }
            if (Form1.days[0].condition == "rain" || Form1.days[1].condition == "shower rain")
            {
                icon1.Image = Properties.Resources.rain;
            }
            if (Form1.days[0].condition == "thunderstorm")
            {
                icon1.Image = Properties.Resources.strom;
            }

            if (Form1.days[0].condition == "snow" || Form1.days[1].condition == "light snow")
            {
                icon1.Image = Properties.Resources.snow;
            }

            if (Form1.days[0].condition == "snow" || Form1.days[1].condition == "light snow")
            {
                this.BackgroundImage = Properties.Resources.snowBackround;
            }
            if (Form1.days[0].condition == "light rain" || Form1.days[1].condition == "moderate rain" || Form1.days[1].condition == "light shower" || Form1.days[1].condition == "rain" || Form1.days[1].condition == "shower rain" || Form1.days[1].condition == "thunderstorm")
            {
                this.BackgroundImage = Properties.Resources.rainbackround;
            }
            if (Form1.days[0].condition == "scattered clouds" || Form1.days[0].condition == "broken clouds"
                || Form1.days[0].condition == "overcast" || Form1.days[1].condition == "overcast clouds" || Form1.days[1].condition == "few clouds")
            {
                this.BackgroundImage = Properties.Resources.cloudBackround;
            }

            //display date of weather
            dateOutput2.Text = Form1.days[2].date;

            //display day low temp
            minTemp2.Text = Math.Round(Convert.ToDouble(Form1.days[2].tempLow)) + "°C";

            //display day high temp
            maxTemp2.Text = Math.Round(Convert.ToDouble(Form1.days[2].tempHigh)) + "°C";

            //display date of weather
            dateOutput3.Text = Form1.days[3].date;

            //display day low temp
            minTemp3.Text = Math.Round(Convert.ToDouble(Form1.days[3].tempLow)) + "°C";

            //display day high temp
            maxTemp3.Text = Math.Round(Convert.ToDouble(Form1.days[3].tempHigh)) + "°C";

            //display date of weather
            dateOutput4.Text = Form1.days[4].date;

            //display day low temp
            minTemp4.Text = Math.Round(Convert.ToDouble(Form1.days[4].tempLow)) + "°C";

            //display day high temp
            maxTemp4.Text = Math.Round(Convert.ToDouble(Form1.days[4].tempHigh)) + "°C";

            //display date of weather
            dateOutput5.Text = Form1.days[5].date;

            //display day low temp
            minTemp5.Text = Math.Round(Convert.ToDouble(Form1.days[5].tempLow)) + "°C";

            //display day high temp
            maxTemp5.Text = Math.Round(Convert.ToDouble(Form1.days[5].tempHigh)) + "°C";

            //display date of weather
            dateOutput6.Text = Form1.days[6].date;

            //display day low temp
            minTemp6.Text = Math.Round(Convert.ToDouble(Form1.days[6].tempLow)) + "°C";

            //display day high temp
            maxTemp6.Text = Math.Round(Convert.ToDouble(Form1.days[6].tempHigh)) + "°C";

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }


    }
}

