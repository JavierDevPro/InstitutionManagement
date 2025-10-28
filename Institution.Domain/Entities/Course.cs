namespace Institution.Domain.Entities;

public class Course
{
    public int Id { get; set; }
    
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
    public string? Duration { get; set; } = string.Empty;
    public int? Capacity { get; set; }
    
    public int ProfessorId { get; set; }
    public int StatusId { get; set; }
    
    public DateOnly DateStart { get; set; }
    public DateOnly DateEnd { get; set; }
    public DateOnly DateCreation { get; set; }
    public DateOnly DateUpdate { get; set; }

    public IEnumerable<Inscription>? inscriptions { get; set; } = new List<Inscription>();
    public Professor? Professor { get; set; }
    public CourseStatus? Status { get; set; }
}