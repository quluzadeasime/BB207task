using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAbstract
{
    internal class Car : Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        private int _maxSpeed { get; set; }
        public int MaxSpeed
        {
            get { return _maxSpeed; }
            set
            {
                if (value > 0)
                {
                    _maxSpeed = value;
                }
                else
                {
                    Console.WriteLine("Duzgun deyer daxil edin!!");
                }
            }
        }
        public Car(string brand, string model, int year) : base(year)
        {
            if (string.IsNullOrEmpty(brand) || string.IsNullOrEmpty(model))
                Console.WriteLine("Brand ve Model bos ola bilmez");
            Brand = brand;
            Model = model;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("****************************************************************************");
            Console.WriteLine($"Car: Brand: {Brand} | Model: {Model} | Year: {Year} | Color: {Color} | Max Speed: {MaxSpeed}"); ;
        }
       
    }
}
