using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManagment
{
    internal class Student
    {
        private static int _id = 0;
        public string FullName { get; set; }
        public int Point { get; set; }
        public int Id { get; }

        public Student(string fullName, int point)
        {
            _id++;
            Id = _id;
            FullName = fullName;
            Point = point;
        }
        public void StudentInfo()
        {
            Console.WriteLine($"Id: {Id}  |  Full Name : {FullName}  |  Point: {Point}");
        }
    }
}
