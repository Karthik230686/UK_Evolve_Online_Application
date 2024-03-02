using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Weather
    {
        public string main { get; set; }
        public string description { get; set; }
       // public string base { get; set; }
        public int id { get; set; }

        public coord CoordObj {get;set;}
        public main  MainObj { get; set; }
    }
}


