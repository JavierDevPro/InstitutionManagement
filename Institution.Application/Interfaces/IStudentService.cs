using Institution.Application.Dtos;
using Institution.Domain.Entities;

namespace Institution.Application.Interfaces;

public interface IStudentService
{
    Task<IEnumerable<StudentDto>>? GetAll();
    Task<StudentDto>? Create(StudentCreateDto entity);
    Task<StudentDto>? Update(int Id, StudentUpdateDto entity);
    Task<bool>? Delete(int Id);
}