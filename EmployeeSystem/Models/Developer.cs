namespace EmployeeSystem.Models;

public class Developer : Employee
{
    public void Code()
    {
        Console.WriteLine($"{Name} is coding.");
        Console.WriteLine($"{Name}'s salary is ${Salary}");
    }
}