namespace Institution.Application.Dtos;

public class CourseDto
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
}

public class CourseCreationDto
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
    public string? Duration { get; set; } = string.Empty;
    public int? Capacity { get; set; }
    
    public int ProfessorId { get; set; }
    public int StatusId { get; set; }
    
    public DateOnly DateStart { get; set; }
    public DateOnly DateEnd { get; set; }
}

public class CourseUpdateDto
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
    public string? Duration { get; set; } = string.Empty;
    public int? Capacity { get; set; }
    
    public int ProfessorId { get; set; }
    public int StatusId { get; set; }
    
    public DateOnly DateStart { get; set; }
    public DateOnly DateEnd { get; set; }
    
    public DateOnly DateUpdate { get; set; }
}