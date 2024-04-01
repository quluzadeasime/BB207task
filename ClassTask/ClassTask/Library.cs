using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    internal class Library
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Car[] Cars = new Car[0];

        public Library()
        {
            Cars = new Car[0];
        }
        public Library(string name, int _id)
        {
            Name = name;
            Id = _id;
            Cars = new Car[0];
        }

        public void AddCar(Car car)
        {
            Array.Resize(ref Cars, Cars.Length + 1);
            Cars[Cars.Length - 1] = car;
        }

        public Car[] ShowAllCars()
        {
            return Cars;
        }

        public Car[] GetAllCars()
        {
            return Cars;
        }

        public Car[] FindCarById(int id)
        {
            Car[] carId = new Car[0];
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i].Id == id)
                {
                    carId[carId.Length - 1] = Cars[i];
                    Array.Resize(ref carId, carId.Length + 1);
                }
            }
            return carId;
        }

        public Car[] FindCarByCarCode(string carCode)
        {
            Car[] findCarCode = new Car[0];
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i].CarCode == carCode)
                {
                    findCarCode[findCarCode.Length - 1] = Cars[i];
                    Array.Resize(ref findCarCode, findCarCode.Length + 1);
                }
            }
            return findCarCode;
        }

        public Car[] FindCarsBySpeedInterval(int minSpeed, int maxSpeed)
        {
            Car[] cars = new Car[0];
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i].Speed >= minSpeed && Cars[i].Speed <= maxSpeed)
                {
                    cars[cars.Length - 1] = Cars[i];
                    Array.Resize(ref cars, cars.Length + 1);
                }
            }
            return cars;
        }
    }
}
