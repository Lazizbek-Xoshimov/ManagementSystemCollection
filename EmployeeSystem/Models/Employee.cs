namespace EmployeeSystem.Models;

public class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public void Work()
    {
        Console.WriteLine($"{Name} is working.");
    }
}