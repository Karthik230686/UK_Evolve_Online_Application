using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IWeatherRepository
    {
        public  Task<Weather> GetWeatherInfo();
    }
}
