namespace Institution.Domain.Entities;

public class CourseStatus
{
    public int Id { get; set; }
    public string Status { get; set; }
    
    public DateOnly DateCreation { get; set; }
    public DateOnly DateUpdate { get; set; }

    public IEnumerable<Course> Courses { get; set; } = new List<Course>();
}