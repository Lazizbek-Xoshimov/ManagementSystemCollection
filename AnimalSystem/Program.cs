using AnimalSystem.Models;

namespace AnimalSystem;

public class Program
{
    public static void Main(string[] args)
    {
        Dog dog = new Dog();
        
        Console.Write("Kuchugingizning ismini kiriting: ");
        dog.Name = Console.ReadLine();

        dog.Eat();
        dog.Bark();

        Cat cat = new Cat();

        Console.Write("Mushugingizning ismini kiriting: ");
        cat.Name = Console.ReadLine();

        cat.Eat();
        cat.Meow();
    }
}