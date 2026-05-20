namespace TransportSystem.Models;

public class Transport
{
    public string Brand { get; set; }

    public void Move()
    {
        Console.WriteLine($"{Brand} is moving.");
    }
}