using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAbstract
{
    internal class Bus:Vehicle 
    {
        private int _passengerCount {  get; set; }
        public int PassengerCount
        {
            get
            {
                return _passengerCount;
            }
            set
            {
                if(value > 0)
                {
                    _passengerCount = value;
                }
                else
                {
                    Console.WriteLine("Duzgun say daxil edin!!");
                }
            }
        }
       
        public Bus(int _passengerCount, int year):base(year)
        {
            if(_passengerCount <= 0)
            {
                Console.WriteLine("Sernisin sayi menfi ve ya 0 ola bilmez!!");
            }
            PassengerCount = _passengerCount;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("****************************************************************************");
            Console.WriteLine($"BUS: Passenger Count: {PassengerCount} | Year: {Year}");
        }
    }
}
