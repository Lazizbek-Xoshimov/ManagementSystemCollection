namespace AnimalSystem.Models;

public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine($"{Name} is barking.");
    }

    public void SetAge(int age)
    {
        if (age < 0)
            Console.WriteLine("Age cannot be a negative value.");
        else
            Age = age;
    }

    public void ShowAge()
    {
        Console.WriteLine($"{Name} is {Age} years old.");
    }
}