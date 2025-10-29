using Institution.Domain.Entities;
using Institution.Domain.Interfaces;
using Institution.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Institution.Infrastructure.Repositories;

public class ProfessorRepository : IRepository<Professor>
{
    private readonly AppDbContext _context;

    public ProfessorRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Professor>> GetAll()
    {
        return await _context.Professors.ToListAsync();
    }

    public async Task<Professor> Create(Professor entity)
    {
        var Professor = _context.Professors.Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<Professor> Update(int Id, Professor entity)
    {
        var existingProfessor = _context.Professors.FirstOrDefault(s => s.Id == Id);
        if (existingProfessor == null) return null;
        
        existingProfessor.Name = entity.Name;
        existingProfessor.LastName = entity.LastName;
        existingProfessor.Document = entity.Document;
        existingProfessor.Email = entity.Email;
        existingProfessor.IsActive = entity.IsActive;
        existingProfessor.PhoneNumber = entity.PhoneNumber;
        existingProfessor.DateUpdate = entity.DateUpdate;
        existingProfessor.Speciality = entity.Speciality;
        
        _context.Professors.Update(existingProfessor);
        
        await _context.SaveChangesAsync();
        return existingProfessor;
    }

    public async Task<bool> Delete(int Id)
    {
        var existingProfessor = _context.Professors.FirstOrDefault(s => s.Id == Id);
        if (existingProfessor == null) return false;
        _context.Professors.Remove(existingProfessor);
        await _context.SaveChangesAsync();
        return true;
    }
    public async Task<bool> AlreadyExist(int Id)
    {
        var request = await _context.Professors.FirstOrDefaultAsync(c => c.Id == Id);
        return (request == null) ? false : true;
    }
}