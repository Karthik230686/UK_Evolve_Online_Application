using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Repository1
{
    public class WetherRepository: IWeatherRepository
    {
        public async Task<Weather> GetWeatherInfo()
        {
            string apiUrl = "http://api.openweathermap.org/data/2.5/weather?q=London&appid=02ebee3c9a21db50b26de1a5dd0a88a1&units=metric&mode=json";

            string inputJson = (new JavaScriptSerializer()).Serialize(apiUrl);
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.UploadString(apiUrl + "/GetCustomers", inputJson);
            Weather WeatherDetails = (new JavaScriptSerializer()).Deserialize<Weather>(json);
            
            return  await Task<WeatherDetails>;

        }
    }
}
