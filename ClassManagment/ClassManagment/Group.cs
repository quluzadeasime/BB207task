using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassManagment
{
    internal class Group
    {
        public string GroupNo { get; set; }
        private int _studentLimit { get; set; }
        private Student[] Students;
        public int StudentLimit
        {
            get { return _studentLimit; }
            set
            {
                if (value >= 5 && value <= 18)
                {
                    _studentLimit = value;
                    Students = new Student[_studentLimit];
                }
                else Console.WriteLine("Student Limit is not correct!!");
            }
        }
        public Group(string groupNo, int studentLimit)
        {
            if (!CheckGroupNo(groupNo))
            {
                throw new ArgumentException("Invalid group number format! Group number should consist of 2 uppercase letters followed by 3 digits.");
            }

            if (studentLimit < 5 || studentLimit > 18)
            {
                throw new ArgumentException("Invalid student limit! Student limit should be between 5 and 18.");
            }

            GroupNo = groupNo;
            StudentLimit = studentLimit;
            Students = new Student[0];
        }


        private bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length != 5)
            {
                return false;
            }
            if (!char.IsUpper(groupNo[0]) || !char.IsUpper(groupNo[1]))
            {
                return false;
            }
            for (int i = 2; i < 5; i++)
            {
                if (!char.IsDigit(groupNo[i]))
                {
                    return false;
                }

            }
            return true;
        }

        public void AddStudent(Student student)
        {
            if (Students.Length < StudentLimit)
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = student;
            }
            else
            {
                Console.WriteLine("Group is full");
            }
        }

        public Student GetStudentById(int id)
        {
            foreach (Student student in Students)
            {
                if (student.Id == id)
                {
                    return student;
                }
            }
            Console.WriteLine("Student not found!");
            return null;
        }
        public void GetAllStudents()
        {
            foreach (Student student in Students)
            {
                if (student != null)
                {
                    student.StudentInfo();
                }
            }
        }
    }
}
