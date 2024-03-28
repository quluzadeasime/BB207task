using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationTask
{
    internal class Product
    {
        public string No { get; set; }
        public string Name { get; set; }
        private double _price;
        private int _count;


        public Product(string name, string no)
        {
            Name = name;
            No = no;
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("Duzgun deyer daxil edin!!");
                }
            }
        }

        public int Count
        {
            get { return _count; }
            set
            {
                if (value > 0)
                {
                    _count = value;
                }
                else Console.WriteLine("Duzgun say daxil edin!!");
            }

        }
    }
}
