using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;


namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string APIKey = "fc3c1454e0d0fd8e0a8f507637893edd";

        private void btn_search_Click(object sender, EventArgs e)
        {
            getWeather();

        }

        private void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TbCity.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                pic_Icon.ImageLocation = "https://openweathermap.org/img/w/" + info.weather[0].icon + ".png";
                lab_Conditions.Text = info.weather[0].main;
                lab_Detail.Text = info.weather[0].description;
                lab_Sunrise.Text = convertDateTime(info.sys.sunrise).ToString();
                lab_Sunset.Text = convertDateTime(info.sys.sunset).ToString();
                lab_WindSpeed.Text = info.wind.speed.ToString();
                lab_Pressure.Text = info.main.pressure.ToString();

            }
        }
        DateTime convertDateTime(long millisec)
        {
            DateTime day = new DateTime(1970,1,1,0,0,0, DateTimeKind.Utc);
            day = day.AddSeconds(millisec).ToLocalTime();
            return day;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
