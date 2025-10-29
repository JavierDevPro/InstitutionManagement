using Institution.Domain.Entities;
using Institution.Domain.Interfaces;
using Institution.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Institution.Infrastructure.Repositories;

public class StudentRepository : IRepository<Student>
{
    private readonly AppDbContext _context;

    public StudentRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Student>> GetAll()
    {
        return await _context.Students.ToListAsync();
    }

    public async Task<Student> Create(Student entity)
    {
        var student = _context.Students.Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<Student> Update(int Id, Student entity)
    {
        var existingStudent = _context.Students.FirstOrDefault(s => s.Id == Id);
        if (existingStudent == null) return null;
        existingStudent.Name = entity.Name;
        existingStudent.LastName = entity.LastName;
        existingStudent.Document = entity.Document;
        existingStudent.Email = entity.Email;
        existingStudent.IsActive = entity.IsActive;
        existingStudent.PhoneNumber = entity.PhoneNumber;
        existingStudent.DateUpdate = entity.DateUpdate;
        _context.Students.Update(existingStudent);
        await _context.SaveChangesAsync();
        return existingStudent;
    }

    public async Task<bool> Delete(int Id)
    {
        var existingStudent = _context.Students.FirstOrDefault(s => s.Id == Id);
        if (existingStudent == null) return false;
        _context.Students.Remove(existingStudent);
        await _context.SaveChangesAsync();
        return true;
    }
}