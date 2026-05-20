namespace TransportSystem.Models;

public class Bike : Transport
{
    public void Ride()
    {
        Console.WriteLine($"{Brand} rode away.");
    }
}