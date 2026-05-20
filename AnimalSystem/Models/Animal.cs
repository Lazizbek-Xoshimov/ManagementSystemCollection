namespace AnimalSystem.Models;

public class Animal
{
    public string Name { get; set; }
    protected int Age { get; set; }

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }
}