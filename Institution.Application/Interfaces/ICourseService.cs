using Institution.Domain.Entities;
using Institution.Application.Dtos;

namespace Institution.Application.Interfaces;

public interface IcourseService
{
    Task<IEnumerable<CourseDto>> GetAll();
    Task<CourseDto> Create(CourseCreationDto entity);
    Task<CourseDto> Update(int Id, CourseUpdateDto entity);
    Task<bool> Delete(int Id);
}
