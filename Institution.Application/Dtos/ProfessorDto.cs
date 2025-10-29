namespace Institution.Application.Dtos;

public class ProfessorDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Document { get; set; }
    public string Email { get; set; }
    public string? PhoneNumber { get; set; }

    public bool IsActive { get; set; }
    public string Speciality { get; set; }

    public DateOnly BirthDate {get; set;}
    public DateOnly DateCreation {get; set;}
    public DateOnly DateUpdate {get; set;}
}

public class ProfessorCreateDto
{
    public string Name {get; set;} 
    public string LastName {get; set;}
    public string Document {get; set;}
    public string Email {get; set;}
    public string? PhoneNumber {get; set;}

    public bool IsActive { get; set; }
    
    public DateOnly BirthDate {get; set;}
}

public class ProfessorUpdateDto
{
    public string Name {get; set;} 
    public string LastName {get; set;}
    public string Document {get; set;}
    public string Email {get; set;}
    public string? PhoneNumber {get; set;}

    public bool IsActive { get; set; }

    public DateOnly BirthDate {get; set;}
}