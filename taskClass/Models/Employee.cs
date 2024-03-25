using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskClass.Models
{
    internal class Employee
    {
        public int Id;
        public string Name;
        public string Surname;
        public byte Age;
        public string DepartmentName;
        public decimal Salary;

        public Employee()
        {
            
        }
        public Employee(int id, string name, string surname,byte age,string departmentName, decimal salary)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Age = age;
            DepartmentName = departmentName;
            Salary = salary;
        }

    }
}
