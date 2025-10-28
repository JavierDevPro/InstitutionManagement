namespace Institution.Domain.Entities;

public class Professor : Person
{
    public int Id { get; set; }
    
    public string Speciality { get; set; }

    public IEnumerable<Course>? Courses { get; set; }
}