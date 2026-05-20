using AnimalSystem.Models;

namespace AnimalSystem;

public class Program
{
    public static void Main(string[] args)
    {
        Dog dog = new Dog();
        
        Console.Write("Enter your dog's name: ");
        dog.Name = Console.ReadLine();

        dog.Eat();
        dog.Bark();

        Console.Write($"Enter {dog.Name}'s age: ");
        int dogAge = int.Parse(Console.ReadLine());

        dog.SetAge(dogAge);
        dog.ShowAge();

        Console.WriteLine();

        Cat cat = new Cat();

        Console.Write("Enter your cat's name: ");
        cat.Name = Console.ReadLine();

        cat.Eat();
        cat.Meow();
    }
}