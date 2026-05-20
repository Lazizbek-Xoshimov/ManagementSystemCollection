namespace UniversityManagement.Models;

public class Teacher : Person
{
    public string Subject { get; set; }

    public Teacher(string name, string subject) : base(name)
    {
        Subject = subject;
    }
}