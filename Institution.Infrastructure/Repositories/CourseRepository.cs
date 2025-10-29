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

    public Task<Course> Update(int Id, Course entity)
    {

        return null
    }

    public async Task<bool> AlreadyExist(int Id)
    {
        var request = await 
    }

    public Task<bool> Delete(int Id)
    {
        throw new NotImplementedException();
    }
    public async Task<Course> ShowDetail(Course entity)
    {
        var course = await _context.Courses
            .Include(c => c.Professor)
            .Include(c => c.Status)
            .FirstOrDefaultAsync(c => c == entity);

        return course;
    }
}