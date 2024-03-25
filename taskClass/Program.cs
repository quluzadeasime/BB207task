using System.ComponentModel;
using System.Globalization;
using taskClass.Models;

namespace taskClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();
            bool running = true;

            Console.WriteLine("============ Welcome to Department App ============\n");

            do
            {
                if (department.Name == null)
                {
                    Console.WriteLine("      ========= Create Section =========\n");
                    Console.WriteLine("\t1. Create Department");
                    Console.WriteLine("\t0. Exit");
                    Console.Write("\n\tPlease, enter a number(0-1): ");
                    string userChoice = Console.ReadLine();
                    if (int.TryParse(userChoice, out int choice))
                    {
                        if (choice == 0) running = false;
                        else if (choice == 1)
                        {
                            CreateDepartment(department);
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice, you should be enter a number between 0 and 1!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice, you should be enter a number!");
                    }
                }
                else
                {
                    Console.WriteLine($"\n     ============== {department.Name} ==============\n");
                    Console.WriteLine("\t1. Add Employee");
                    Console.WriteLine("\t2. Get Employee By Id");
                    Console.WriteLine("\t3. Get All Employee");
                    Console.WriteLine("\t4. Get Employee By Salary(Max,Min)");
                    Console.WriteLine("\t0. EXIT");
                    Console.Write("\n\tPlease, enter a number(0-4): ");
                    string userChoice = Console.ReadLine();
                    if (int.TryParse(userChoice, out int choice))
                    {
                        if (choice == 0) running = false;
                        else Menu(department, choice);
                    }
                    else
                    {
                        Console.WriteLine("\tInvalid choice, you should be enter a number!");
                    }
                }
            }
            while (running);
            Console.WriteLine("\n\t  Program has been stopped! \n");
            Console.WriteLine("================================================");

        }
        public static void CreateDepartment(Department department)
        {
            Console.WriteLine("\nPlease, enter department's information:");
            Console.Write("Department name: ");
            department.Name = Console.ReadLine();
            Console.WriteLine("\nNew department has been created!\n");
        }
        public static void Menu(Department department, int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nPlease, enter employee's information");
                    Console.Write("Employee Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Employee Surname: ");
                    string surname = Console.ReadLine();
                    Console.Write("Employee Age: ");
                    byte age = byte.Parse(Console.ReadLine());
                    Console.Write("Employee Salary: ");
                    decimal salary = decimal.Parse(Console.ReadLine());
                    Console.Write("Employee Id: ");
                    int id = int.Parse(Console.ReadLine());

                    Employee employee = new Employee(id, name, surname, age, department.Name, salary);

                    department.AddEmployee(employee);
                    Console.WriteLine("\nNew employee has been created!");

                    break;

                case 2:
                    Console.WriteLine("\nPlease, enter employee's id");
                    Console.Write("Employee id: ");
                    int employeeId = int.Parse(Console.ReadLine());

                    Employee oldEmployee = department.GetEmployeeById(employeeId);
                    Console.WriteLine("\nEmployee information: ");
                    Console.WriteLine("Id: " + oldEmployee.Id);
                    Console.WriteLine("Name: " + oldEmployee.Name);
                    Console.WriteLine("Surname: " + oldEmployee.Surname);
                    Console.WriteLine("Age: " + oldEmployee.Age);
                    Console.WriteLine("Salary: " + oldEmployee.Salary);
                    Console.WriteLine("Department: " + oldEmployee.DepartmentName);
                    Console.WriteLine();

                    break;

                case 3:
                    Console.WriteLine("\nAll employees information");
                    Console.WriteLine("Id | Name | Surname | Age | Salary");
                    var allEmployees = department.GetAllEmployees();
                    for (int i = 0; i < allEmployees.Length - 1; i++)
                    {
                        Console.WriteLine($"{allEmployees[i].Id} | {allEmployees[i].Name} | {allEmployees[i].Surname} | {allEmployees[i].Age} | {allEmployees[i].Salary}");
                    }
                    Console.WriteLine();
                    break;

                case 4:

                    Console.WriteLine("\nAll employees information by salary");
                    Console.Write("Min value: ");
                    decimal min = decimal.Parse(Console.ReadLine());
                    Console.Write("Max value: ");
                    decimal max = decimal.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Console.WriteLine("Id | Name | Surname | Age | Salary");
                    var allEmployeesBySalary = department.GetAllEmployeesBySalary(max, min);
                    for (int i = 0; i < allEmployeesBySalary.Length-1; i++)
                    {
                        Console.WriteLine($"{allEmployeesBySalary[i].Id}  |  {allEmployeesBySalary[i].Name}  |  {allEmployeesBySalary[i].Surname}  |  {allEmployeesBySalary[i].Age}  |  {allEmployeesBySalary[i].Salary}");
                    }
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Invalid choice, you should be enter a number between 0 and 4!");
                    break;
            }

        }
    }
}
