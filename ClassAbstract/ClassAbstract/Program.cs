namespace ClassAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicle = new Vehicle[2];

            Car car = new Car("Hyundai", "Sonata", 6);
            car.Color = "Qara";
            car.MaxSpeed = 180;

            Bus bus = new Bus(13, 10);
            bus.Color = "Ag";

            vehicle[0] = car;
            vehicle[1] = bus;

            foreach (Vehicle v in vehicle)
            {
               v.ShowInfo();
            }
        }
    }
}
