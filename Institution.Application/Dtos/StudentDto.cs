namespace Institution.Application.Dtos;

public class StudentDto
{
    public int Id { get; set; }
    public string Name {get; set;} 
    public string LastName {get; set;}
    public string Document {get; set;}
    public string Email {get; set;}
    public string? PhoneNumber {get; set;}

    public bool IsActive { get; set; }
    
    public DateOnly BirthDate {get; set;}
    public DateOnly DateCreation {get; set;}
    public DateOnly DateUpdate {get; set;}
}

public class StudentCreateDto
{
    public string Name {get; set;} 
    public string LastName {get; set;}
    public string Document {get; set;}
    public string Email {get; set;}
    public string? PhoneNumber {get; set;}

    public bool IsActive { get; set; }
    
    public DateOnly BirthDate {get; set;}
}

public class StudentUpdateDto
{
    public string Name {get; set;} 
    public string LastName {get; set;}
    public string Document {get; set;}
    public string Email {get; set;}
    public string? PhoneNumber {get; set;}

    public bool IsActive { get; set; }

    public DateOnly BirthDate {get; set;}
}