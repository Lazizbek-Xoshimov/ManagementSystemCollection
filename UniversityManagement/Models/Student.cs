namespace UniversityManagement.Models;

public class Student : Person
{
    public int Grade { get; set; }

    public Student(string name, int grade) : base(name)
    {
        grade = Grade;
    }
}