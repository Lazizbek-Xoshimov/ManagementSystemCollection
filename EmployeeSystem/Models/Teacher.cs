namespace EmployeeSystem.Models;

public class Teacher : Employee
{
    public void Teach()
    {
        Console.WriteLine($"{Name} is teaching.");
        Console.WriteLine($"{Name}'s salary is ${Salary}");
    }
}