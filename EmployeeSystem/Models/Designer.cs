namespace EmployeeSystem.Models;

public class Designer : Employee
{
    public void Design()
    {
        Console.WriteLine($"{Name} is designing.");
        Console.WriteLine($"{Name}'s salary is ${Salary}");
    }
}