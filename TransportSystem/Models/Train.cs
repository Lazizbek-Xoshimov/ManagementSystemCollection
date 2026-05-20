namespace TransportSystem.Models;

public class Train : Transport
{
    public void CarryPassengers()
    {
        Console.WriteLine($"{Brand} left the station.");
    }
}