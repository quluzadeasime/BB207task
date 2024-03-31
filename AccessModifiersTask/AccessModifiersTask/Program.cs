using System.Data;
using System.Security.Cryptography;

namespace AccessModifiersTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************** Welcome  ***************");
            Group group = new Group();
            bool running = true;

            do
            {
                if (group.No == null && group.StudentLimit == 0)
                {
                    Console.WriteLine("      ========= Create Section =========\n");
                    Console.WriteLine("\t1. Create Group");
                    Console.WriteLine("\t0. Exit");
                    Console.Write("\n\tPlease, enter a number(0-1): ");
                    string userChoice = Console.ReadLine();

                    if (int.TryParse(userChoice, out int choice))
                    {
                        if (choice == 0) running = false;
                        else if (choice == 1)
                        {
                            CreateGroup(group);
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
                    Console.WriteLine($"\n     ============== {group.No} ==============\n");
                    Console.WriteLine("\t1. Add Student");
                    Console.WriteLine("\t2. Get All Student");
                    Console.WriteLine("\t3. Get Student by Search");
                    Console.WriteLine("\t0. EXIT");
                    Console.Write("\n\tPlease, enter a number(0-3): ");
                    string userChoice = Console.ReadLine();
                    if (int.TryParse(userChoice, out int choice))
                    {
                        if (choice == 0) running = false;
                        else
                        {
                            if(Menu(group, choice))
                            {
                                running = false;
                            }
                            
                        }
                    }
                }
            }
            while (running);
            Console.WriteLine("\n\t  Program has been stopped! \n");
            Console.WriteLine("================================================");

        }

        private static void CreateGroup(Group group)
        {
            Console.WriteLine("\nPlease, enter group's information:");
        P1:
            Console.Write("Group name: ");
            group.No = Console.ReadLine();
            if (group.No == null)
            {
                goto P1;
            }
        P2:
            Console.Write("Student limit: ");
            group.StudentLimit = int.Parse(Console.ReadLine());
            if (group.StudentLimit == 0)
            {
                goto P2;
            }
            Console.WriteLine("\nNew group has been created!\n");
        }
        public static bool Menu(Group group, int choice)
        {
            bool check = false;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nPlease, enter groups information");
                    Console.Write("Student full name: ");
                    string fullName = Console.ReadLine();

                    Console.Write("Student's average: ");
                    double avgPoint = double.Parse(Console.ReadLine());

                    Student newStudent = new Student(fullName, group.No, avgPoint);

                    if (!group.AddStudent(newStudent))
                    {
                        check = true;
                    }

                    break;
                case 2:
                    Console.WriteLine("\nAll students information");
                    Console.WriteLine();
                    Console.WriteLine("No    | Full Name | Average");
                    Console.WriteLine();
                    var allStudents = group.ShowAllStudents();
                    foreach (var item in allStudents)
                    {
                        Console.WriteLine($"{item.GroupNo} | {item.FullName} | {item.AvgPoint} ");
                    }
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("\nAll students information by search");
                    Console.Write("Input: ");
                    string search = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("No    | Full Name | Average");
                    Console.WriteLine();
                    var allStudentsBySearch = group.FilteredStudents(search);
                    foreach (var item in allStudentsBySearch)
                    {
                        Console.WriteLine($"{item.GroupNo} | {item.FullName} | {item.AvgPoint} ");
                    }
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Invalid choice, you should be enter a number between 0 and 3!");
                    break;
            }

            return check;
        }
    }
}
