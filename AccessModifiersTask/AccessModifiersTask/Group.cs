using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AccessModifiersTask
{
    internal class Group
    {
        public Student[] Students = new Student[0];
        private string _no;
        public string No
        {
            get { return _no; }
            set
            {
                if (Regex.IsMatch(value, @"^[A-Z]{2}\d{3}$"))
                {
                    _no = value;
                }
                else
                {
                    Console.WriteLine("Invalid Group Name(AA101)");
                    _no = null;
                }
            }
        }

        private int _studentLimit;
        public int StudentLimit
        {
            get { return _studentLimit; }
            set
            {
                if (value > 0 && value <= 20)
                {
                    _studentLimit = value;
                }
                else
                {
                    Console.WriteLine("Please enter a number between 0 and 20");
                    _studentLimit = 0;
                }
            }
        }

        public Group()
        {

        }

        public Group(string no, int studentLimit)
        {
            No = no;
            StudentLimit = studentLimit;
        }

        public bool AddStudent(Student student)
        {
            if (Students.Length < StudentLimit)
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = student;
                Console.WriteLine("\nNew student has been created!");
                return true;
            }
            else
            {
                Console.WriteLine("\nThe group is full");
                return false;
            }
            
        }

        public Student[] ShowAllStudents()
        {
            return Students;
        }

        public Student[] FilteredStudents(string search)
        {
            Student[] filteredStudent = new Student[0];
            foreach (Student student in Students)
            {
                if (student.FullName.Contains(search) || 
                    student.GroupNo.Contains(search) ||
                    student.AvgPoint.ToString().Contains(search))
                {
                    Array.Resize(ref filteredStudent, filteredStudent.Length + 1);
                    filteredStudent[filteredStudent.Length - 1] = student;
                }
            }
            return filteredStudent;
        }
    }
}
