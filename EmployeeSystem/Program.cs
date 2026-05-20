using EmployeeSystem.Models;

namespace EmployeeSystem;

public class Program
{
    public static void Main(string[] args)
    {
        Developer developer = new Developer();

        Console.Write("Enter Developer's name: ");
        developer.Name = Console.ReadLine();

        Console.Write("Enter Developer's salary: ");
        developer.Salary = decimal.Parse(Console.ReadLine());

        developer.Work();
        developer.Code();

        Teacher teacher = new Teacher();

        Console.Write("Enter Teacher's name: ");
        teacher.Name = Console.ReadLine();

        Console.Write("Enter Teacher's salary: ");
        teacher.Salary = decimal.Parse(Console.ReadLine());

        teacher.Work();
        teacher.Teach();

        Designer designer = new Designer();

        Console.Write("Enter Designer's name: ");
        designer.Name = Console.ReadLine();

        Console.Write("Enter Designer's salary: ");
        designer.Salary = decimal.Parse(Console.ReadLine());

        designer.Work();
        designer.Design();
    }
}