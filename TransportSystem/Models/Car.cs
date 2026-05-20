namespace TransportSystem.Models;

public class Car : Transport
{
    public void Drive()
    {
        Console.WriteLine($"{Brand} drove away.");
    }
}