namespace Institution.Application.Dtos;

public class InscriptionDto
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public DateOnly DateCreation { get; set; }
    public DateOnly DateUpdate { get; set; }
}

public class InscriptionCreationDto
{
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public DateOnly DateCreation { get; set; }
    public DateOnly DateUpdate { get; set; }
}

public class InscriptionUpdateDto
{
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public DateOnly DateUpdate { get; set; }
}

