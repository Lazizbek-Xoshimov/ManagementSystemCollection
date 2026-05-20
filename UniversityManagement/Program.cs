using UniversityManagement.Models;

namespace UniversityManagement;

public class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student("Ali", 5);

        Console.WriteLine(student.ShowProperties());

        Teacher teacher = new Teacher("Hasan", "Math");

        Console.WriteLine(teacher.ShowProperties());
    }
}