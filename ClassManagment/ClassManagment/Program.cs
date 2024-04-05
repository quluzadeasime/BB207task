
using System.ComponentModel.Design;

namespace ClassManagment
{
    internal class Program
    {
        static Student student;
        static Group group;
        static void Main(string[] args)
        {
            CreateUser();
            bool running = true;
            int choice;
            do
            {
                Console.WriteLine("***********Menu***********");
                Console.WriteLine("1.Show info");
                Console.WriteLine("2.Create new group");
                Console.Write("Your choice: ");
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        if (student != null)
                            student.StudentInfo();
                        break;
                    case 2:
                        CreateGroup();
                        int choice2;
                        do
                        {
                            Console.WriteLine("***********Menu********");
                            Console.WriteLine("1.Show all students");
                            Console.WriteLine("2.Get student by id");
                            Console.WriteLine("3.Add student");
                            Console.WriteLine("0.Quit");
                            Console.Write("Your choice: ");
                            int.TryParse(Console.ReadLine(), out choice2);
                            switch (choice2)
                            {
                                case 1:
                                    if (group != null)
                                        group.GetAllStudents();
                                    else Console.WriteLine("No group created!");
                                    break;
                                case 2:
                                    if (group != null)
                                    {
                                        Console.Write("Enter id: ");
                                        int id;
                                        while (!int.TryParse(Console.ReadLine(), out id) || id <= 0)
                                        {
                                            Console.WriteLine("Invalid input for student id! Please enter a positive integer.");
                                            Console.Write("Enter student id: ");
                                        }
                                        Student foundStudent = group.GetStudentById(id);
                                        if (foundStudent != null)
                                        {
                                            foundStudent.StudentInfo();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Student with id " + id + " not found!");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("No group created!");
                                    }
                                    break;
                                case 3:
                                    if (group != null)
                                    {
                                        Console.WriteLine("Enter student information: ");
                                        Console.Write("Enter full name: ");
                                        string fullName = Console.ReadLine();
                                        Console.Write("Enter point: ");
                                        int point;
                                        while (!int.TryParse(Console.ReadLine(), out point) || point < 0)
                                        {
                                            Console.WriteLine("Invalid input for point!");
                                            Console.Write("Enter point: ");
                                        }
                                        Student newStudent = new Student(fullName, point);
                                        group.AddStudent(newStudent);
                                        Console.WriteLine("Student added to group!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("No group created!");
                                    }
                                    break;
                                case 0:
                                    Console.WriteLine("Exiting...");
                                    break;
                                default:
                                    Console.WriteLine("Please try again!!");
                                    break;
                            }
                        } while (choice2 == 4);
                        break;
                    default:
                        Console.WriteLine("Please try again!!");
                        break;
                }

            } while (running = false);
        }

        static void CreateUser()
        {
            Console.WriteLine("Enter user information: ");
            Console.Write("Enter full name: ");
            string fullName = Console.ReadLine();
            int point;
            do
            {
                Console.Write("Enter point: ");
            } while (!int.TryParse(Console.ReadLine(), out point) || point < 0 || point > 100);

            student = new Student(fullName, point);
            Console.WriteLine("User created!!");
        }

        static void CreateGroup()
        {
            Console.WriteLine("Enter group information: ");
            string groupNo;
            bool checkGroupNo;
            do
            {
                Console.Write("Enter Group No(BB207): ");
                groupNo = Console.ReadLine();
                checkGroupNo = CheckGroupNo(groupNo);
                if (!checkGroupNo)
                {
                    Console.WriteLine("Group no is not correct!");
                }
            } while (!checkGroupNo);

            int studentLimit;
            do
            {
                Console.Write("Enter student limit (5 to 18): ");
                if (!int.TryParse(Console.ReadLine(), out studentLimit) || studentLimit < 5 || studentLimit > 18)
                {
                    Console.WriteLine("Student limit is not correct!");
                }
            } while (studentLimit < 5 || studentLimit > 18);

            group = new Group(groupNo, studentLimit);
            Console.WriteLine("Group created!!");

        }
        static bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length != 5)
                return false;

            if (!char.IsUpper(groupNo[0]) || !char.IsUpper(groupNo[1]))
                return false;

            for (int i = 2; i < 5; i++)
            {
                if (!char.IsDigit(groupNo[i]))
                    return false;
            }

            return true;
        }

    }
}
