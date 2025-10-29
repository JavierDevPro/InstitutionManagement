using Institution.Domain.Entities;
using Institution.Domain.Interfaces;
using Institution.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Institution.Infrastructure.Repositories;

public class CourseRepository : IRepository<Course>
{
    private readonly AppDbContext _context;

    public CourseRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Course>> GetAll()
    {
        var courses = await _context.Courses.ToListAsync();
        return courses;
    }

    public async Task<Course> Create(Course entity)
    {
        var course = _context.Courses.Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<Course> Update(int Id, Course entity)
    {
        var requested = await _context.Courses.FirstOrDefaultAsync(c => c.Id == Id);
        if (requested == null) return null;

        requested.Name = entity.Name;
        requested.Description = entity.Description;
        requested.Duration = entity.Duration;
        requested.Capacity = entity.Capacity;
        requested.ProfessorId = entity.ProfessorId;
        requested.StatusId = entity.StatusId;
        requested.DateStart = entity.DateStart;
        requested.DateEnd = entity.DateEnd;
        requested.DateUpdate = DateOnly.FromDateTime(DateTime.Now);

        await _context.SaveChangesAsync();

        return requested;
    }

    public async Task<bool> Delete(int Id)
    {
        var existingCourse = _context.Courses.FirstOrDefault(s => s.Id == Id);
        if (existingCourse == null) return false;
        _context.Courses.Remove(existingCourse);
        await _context.SaveChangesAsync();
        return true;
    }
    public async Task<Course> ShowDetail(Course entity)
    {
        var course = await _context.Courses
            .Include(c => c.Professor)
            .Include(c => c.Status)
            .FirstOrDefaultAsync(c => c == entity);

        return course;
    }
    
    public async Task<bool> AlreadyExist(int Id)
    {
        var request = await _context.Courses.FirstOrDefaultAsync(c => c.Id == Id);
        return (request == null) ? false : true;
    }
}