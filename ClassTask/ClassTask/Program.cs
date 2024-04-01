
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************");
            Library mylibrary = new Library();
            string choice;

            do
            {
                Console.WriteLine("******MENU******");
                Console.WriteLine("1. Add car");
                Console.WriteLine("2. Show all cars");
                Console.WriteLine("3. Find car by Id");
                Console.WriteLine("4. Find car  by car code");
                Console.WriteLine("5. Find car by speed");
                Console.WriteLine("6. Exit");
                Console.Write("Your choice: ");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter car name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter car speed: ");
                        int speed;
                        while (!int.TryParse(Console.ReadLine(), out speed))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid integer.");
                            Console.Write("Enter car speed: ");
                        }
                        Car car = new Car(name, speed);
                        mylibrary.AddCar(car);
                        Console.WriteLine("***********************");
                        break;
                    case "2":
                        Console.Write("All cars: ");
                        GetCars(mylibrary.ShowAllCars());
                        break;
                    case "3":
                        Console.Write("Enter Id: ");
                        int id;
                        while (!int.TryParse(Console.ReadLine(), out id))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid integer.");
                            Console.Write("Enter Id: ");
                        }
                        Car[] foundCars = mylibrary.FindCarById(id);
                        if (foundCars.Length == 0)
                        {
                            Console.WriteLine("No car found with the specified ID.");
                        }
                        else
                        {
                            GetCars(foundCars);
                        }
                        break;
                    case "4":
                        Console.Write("Enter Car Code: ");
                        string carCode = Console.ReadLine();
                        GetCars(mylibrary.FindCarByCarCode(carCode));
                        break;
                    case "5":
                        Console.Write("Enter minimum speed: ");
                        int minSpeed;
                        while (!int.TryParse(Console.ReadLine(), out minSpeed))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid integer.");
                            Console.Write("Enter minimum speed: ");
                        }
                        Console.Write("Enter maximum speed: ");
                        int maxSpeed;
                        while (!int.TryParse(Console.ReadLine(), out maxSpeed))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid integer.");
                            Console.Write("Enter maximum speed: ");
                        }
                        GetCars(mylibrary.FindCarsBySpeedInterval(minSpeed, maxSpeed));
                        break;
                    case "6":
                        Console.WriteLine("Exit program");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 6.");
                        break;
                }
                Console.WriteLine();
            } while (choice != "6");
        }

        static void GetCars(Car[] cars)
        {
            if(cars.Length == 0)
            {
                Console.WriteLine("Cars not found");
                return;
            }
            foreach(Car car in cars)
            {
                Console.WriteLine("Id: {0}, Name: {1}, Speed: {2}, CarCode: {3}", car.Id, car.Name, car.Speed, car.CarCode);
            }
        }
    }
}
