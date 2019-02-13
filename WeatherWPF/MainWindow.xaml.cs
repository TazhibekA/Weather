using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
 
using Newtonsoft.Json;
using WeatherWPF;

namespace WeatherWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         Weather weather = new Weather();
        private void GetJson(string city)
        {
            //string url = $"";

            //HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            //HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            //string response;

            //using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            //{
            //    response = streamReader.ReadToEnd();
            //}

            //WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
            //return weatherResponse;
            using (WebClient client = new WebClient())
            {
                weather = JsonConvert.DeserializeObject<Weather>(client.DownloadString($"http://api.apixu.com/v1/forecast.json?key=cfaae3b46bbb4266bd155654190702&q={city}&days=7"));
                
 

            }
            
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GetJson(city.Text);
            temp.Text = weather.forecast.forecastday[0].day.maxtemp_c.ToString();
            temp1.Text = weather.forecast.forecastday[1].day.maxtemp_c.ToString();
            temp2.Text = weather.forecast.forecastday[2].day.maxtemp_c.ToString();
            temp3.Text = weather.forecast.forecastday[3].day.maxtemp_c.ToString();
            temp4.Text = weather.forecast.forecastday[4].day.maxtemp_c.ToString();
            temp5.Text = weather.forecast.forecastday[5].day.maxtemp_c.ToString();
            temp6.Text = weather.forecast.forecastday[6].day.maxtemp_c.ToString();
            //temp1.Text = weatherResponse.Main.Temp.ToString();
            //temp2.Text = weatherResponse.Main.Temp.ToString();
            //temp3.Text = weatherResponse.Main.Temp.ToString();
            //temp4.Text = weatherResponse.Main.Temp.ToString();
            //temp5.Text = weatherResponse.Main.Temp.ToString();
            //temp6.Text = weatherResponse.Main.Temp.ToString();




        }
    }
}
