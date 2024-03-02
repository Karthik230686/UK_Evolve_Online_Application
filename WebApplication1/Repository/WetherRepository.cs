using Model;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;


namespace Repository
{
    public class WetherRepository : IWeatherRepository
    {
        public async Task<Weather> GetWeatherInfo()
        {
            string apiUrl = "http://api.openweathermap.org/data/2.5/weather?q=London&appid=02ebee3c9a21db50b26de1a5dd0a88a1&units=metric&mode=json";

            string inputJson = (new JavaScriptSerializer()).Serialize(input);
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.UploadString(apiUrl + "/GetCustomers", inputJson);
            List<Weather> customers = (new JavaScriptSerializer()).Deserialize<List<Customer>>(json);
        }
    }
}
