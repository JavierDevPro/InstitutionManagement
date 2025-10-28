namespace Institution.Domain.Entities;

public class Student : Person
{
    public int Id { get; set; }
    
    public IEnumerable<Inscription>? inscriptions { get; set; } = new List<Inscription>();
}