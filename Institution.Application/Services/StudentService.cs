using System.Runtime.InteropServices.JavaScript;
using Institution.Application.Dtos;
using Institution.Application.Interfaces;
using Institution.Domain.Entities;
using Institution.Domain.Interfaces;

namespace Institution.Application.Services;

public class StudentService : IStudentService
{
    private readonly IRepository<Student> _repository;
    
    public StudentService(IRepository<Student> repository)
    {
        _repository = repository;
    }
    
    //MapDto
    public StudentDto MapDto(Student student)
    {
        var Student = new StudentDto
        {
            Id = student.Id,
            Name = student.Name,
            LastName = student.LastName,
            Document = student.Document,
            Email = student.Email,
            IsActive = student.IsActive,
            PhoneNumber = student.PhoneNumber,
            DateUpdate = student.DateUpdate,
            BirthDate = student.BirthDate,
            DateCreation = student.DateCreation
        };
        return Student;
    } 
    
    public async Task<IEnumerable<StudentDto>> GetAll()
    {
        var students = await _repository.GetAll();
        return students.Select(MapDto);
    }

    public async Task<StudentDto>? Create(StudentCreateDto entity)
    {
        var student = new Student
        {
            Name = entity.Name,
            LastName = entity.LastName,
            Document = entity.Document,
            Email = entity.Email,
            IsActive = entity.IsActive,
            PhoneNumber = entity.PhoneNumber,
            BirthDate = entity.BirthDate,
            DateCreation = DateOnly.FromDateTime(DateTime.Now),
            DateUpdate = DateOnly.FromDateTime(DateTime.Now),
        };
        var studentDto = await _repository.Create(student);
        return MapDto(studentDto);
    }

    public async Task<StudentDto> Update(int Id, StudentUpdateDto entity)
    {
        var maped = new Student
        {
            Name = entity.Name,
            LastName = entity.LastName,
            Document = entity.Document,
            Email = entity.Email,
            IsActive = entity.IsActive,
            PhoneNumber = entity.PhoneNumber,
            BirthDate = entity.BirthDate,
            DateCreation = DateOnly.FromDateTime(DateTime.Now),
            DateUpdate = DateOnly.FromDateTime(DateTime.Now),
        };
        var student = await _repository.Update(Id,maped);
        return MapDto(student);
    }

    public async Task<bool> Delete(int Id)
    {
        return await _repository.Delete(Id);
    }
}