using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAbstract
{
    abstract class Vehicle
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public Vehicle(int year)
        {
            Year = year;
        }
        public abstract void ShowInfo();
    }
}
