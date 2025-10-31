using Institution.Application.Dtos;
using Institution.Application.Interfaces;
using Institution.Domain.Entities;
using Institution.Domain.Interfaces;

namespace Institution.Application.Services;

public class CourseService: IcourseService
{
    private readonly IRepository<Course> _repository;

    public CourseService(IRepository<Course> repository)
    {
        _repository = repository;
    }

    public CourseDto MapDto(Course course)
    {
        var Course = new CourseDto
        {
            Id = course.Id,
            Name = course.Name,
            Description = course.Description,
            Duration = course.Duration,
            Capacity = course.Capacity,
            ProfessorId = course.ProfessorId,
            StatusId = course.StatusId,
            DateStart = course.DateStart,
            DateEnd = course.DateEnd,
            DateCreation = course.DateCreation,
            DateUpdate = course.DateUpdate
        };
        return Course;
    }
    
    public async Task<IEnumerable<CourseDto>> GetAll()
    {
        var courses = await _repository.GetAll();
        return courses.Select(MapDto);
    }

    public async Task<CourseDto> Create(CourseCreationDto entity)
    {
        var courseToCreate = new Course
        {
            Name = entity.Name,
            Description = entity.Description,
            Duration = entity.Duration,
            Capacity = entity.Capacity,
            ProfessorId = entity.ProfessorId,
            StatusId = entity.StatusId,
            DateStart = entity.DateStart,
            DateEnd = entity.DateEnd,
            DateCreation = DateOnly.FromDateTime(DateTime.Now),
            DateUpdate = DateOnly.FromDateTime(DateTime.Now),
        };
        return MapDto(await _repository.Create(courseToCreate));
    }

    public async Task<CourseDto> Update(int Id, CourseUpdateDto entity)
    {
        var courseToUpdate = new Course
        {
            Name = entity.Name,
            Description = entity.Description,
            Duration = entity.Duration,
            Capacity = entity.Capacity,
            ProfessorId = entity.ProfessorId,
            StatusId = entity.StatusId,
            DateStart = entity.DateStart,
            DateEnd = entity.DateEnd,
            DateUpdate = DateOnly.FromDateTime(DateTime.Now),
        };
        return MapDto(await _repository.Update(Id,courseToUpdate));
    }

    public async Task<bool> Delete(int Id)
    {
        return await _repository.Delete(Id);
    }
}