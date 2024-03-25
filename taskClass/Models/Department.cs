using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskClass.Models
{

    internal class Department
    {
        public string Name;
        Employee[] Employees;

        public Department()
        {
            Employees = new Employee[1];
        }
        public Department(string name)
        {
            Name = name;

        }

        public void AddEmployee(Employee employee)
        {
            Employees[Employees.Length - 1] = employee;

            Array.Resize(ref Employees, Employees.Length + 1);
        }
        public Employee GetEmployeeById(int id)
        {
            Employee employeeId = new Employee();

            for (int i = 0; i < Employees.Length; i++)
            {
                if (Employees[i].Id == id)
                {
                    employeeId.Name = Employees[i].Name;
                    employeeId.Surname = Employees[i].Surname;
                    employeeId.Age = Employees[i].Age;
                    employeeId.Salary = Employees[i].Salary;
                    employeeId.Id = Employees[i].Id;
                    employeeId.DepartmentName = Employees[i].DepartmentName;
                    break;
                }
            }

            return employeeId;
        }

        public Employee[] GetAllEmployees()
        {

            return Employees;
        }

        public Employee[] GetAllEmployeesBySalary(decimal max, decimal min)
        {
            Employee[] employeesBySalary = new Employee[1];

            for (int i = 0; i < Employees.Length - 1; i++)
            {
                if (Employees[i].Salary <= max && Employees[i].Salary >= min)
                {
                    employeesBySalary[employeesBySalary.Length - 1] = Employees[i];

                    Array.Resize(ref employeesBySalary, employeesBySalary.Length + 1);

                }
            }

            return employeesBySalary;
        }

    }
}
