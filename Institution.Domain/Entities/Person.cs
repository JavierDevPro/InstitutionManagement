namespace Institution.Domain.Entities;

public class Person
{
    public string Name {get; set;} 
    public string LastName {get; set;}
    public string Document {get; set;}
    public string Email {get; set;}
    public string? PhoneNumber {get; set;}

    public DateOnly BirthDate {get; set;}
    public DateOnly DateCreation {get; set;}
    public DateOnly DateUpdate {get; set;}

    public bool IsActive { get; set; }
}