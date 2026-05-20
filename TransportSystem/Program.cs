using TransportSystem.Models;

namespace TransportSystem;

public class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car();

        Console.Write("Enter your car's brand: ");
        car.Brand = Console.ReadLine();

        car.Move();
        car.Drive();

        Bike bike = new Bike();

        Console.Write("Enter your bike's brand: ");
        bike.Brand = Console.ReadLine();

        bike.Move();
        bike.Ride();

        Train train = new Train();

        Console.Write("Enter your train's brand: ");
        train.Brand = Console.ReadLine();

        train.Move();
        train.CarryPassengers();
    }
}