using Institution.Domain.Entities;
using Institution.Domain.Interfaces;
using Institution.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Institution.Infrastructure.Repositories;

public class InscriptionRepository : IRepository<Inscription>
{
    private readonly AppDbContext _context;

    public InscriptionRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Inscription>> GetAll()
    {
        var inscription = await _context.Inscriptions.ToListAsync();
        return inscription;
    }

    public async Task<Inscription> Create(Inscription entity)
    {
        var entry = _context.Inscriptions.Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<Inscription> Update(int Id, Inscription entity)
    {
        var requested = await _context.Inscriptions.FirstOrDefaultAsync(i => i.Id == Id);
        if (requested == null) return null;

        requested.CourseId = entity.CourseId;
        requested.StudentId = entity.StudentId;

        _context.Inscriptions.Update(requested);
        await _context.SaveChangesAsync();

        return requested;
    }

    public async Task<bool> Delete(int Id)
    {
        var existingInscription = _context.Inscriptions.FirstOrDefault(s => s.Id == Id);
        if (existingInscription == null) return false;
        _context.Inscriptions.Remove(existingInscription);
        await _context.SaveChangesAsync();
        return true;
    }
}