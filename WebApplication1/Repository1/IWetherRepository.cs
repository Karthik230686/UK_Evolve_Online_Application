using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository1
{
    public interface IWetherRepository
    {
         Task<Weather> GetWeatherInfo();
    }
}
