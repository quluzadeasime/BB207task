using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExtension
{
    internal class Person
    {
        public static int _id = 0;
        public int Id { get; }
        public string FullName { get; set; }
        private sbyte _age;
        public sbyte Age
        {
            get { return _age; }
            set
            {
                if (value >= 0 && value <= 125)
                {
                    _age = value;
                }
                else Console.WriteLine("Enter correct number!");
            }
        }
        public double Cash { get; set; }
        public Person()
        {

        }
        public Person(string fullName, sbyte age, double cash)
        {
            _id++;
            Id = _id;
            FullName = fullName;
            Age = age;
            Cash = cash;
        }
        public override string ToString()
        {
            return $"Id: {Id} |  FullName: {FullName} | Age: {Age} | Cash: {Cash}";
        }
    }
}
