﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExtension
{
    internal class Product
    {
        public static int _no;
        public int No { get; }
        public string Name { get; set; }
        private double _price;
        private int _count;
        public double Price {
            get { return _price; }
            set
            {
                if(value > 0)
                {
                    _price = value;
                }
                else Console.WriteLine("Enter correct number!");
            }
         }
        public string Type{ get; set; }
        public int Count{ get; set; }


        public Product(string name,double price ,string type,int count)
        {
            _no++;
            No = _no;
            Name = name;
            Price = price;
            Type = type;
            Count = count;
        }
       

        public override string ToString()
        {
            return $"No: {No} | Name: {Name} | Price: {Price} | Type: {Type} | Count:{Count}" ;
        }
    }
}
