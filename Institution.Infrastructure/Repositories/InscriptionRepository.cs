using Institution.Domain.Entities;
using Institution.Domain.Interfaces;
using Institution.Infrastructure.Data;

namespace Institution.Infrastructure.Repositories;

public class InscriptionRepository : IRepository<Inscription>
{
    private readonly AppDbContext _context;

    public CourseRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public Task<IEnumerable<Inscription>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Inscription> Create(Inscription entity)
    {
        throw new NotImplementedException();
    }

    public Task<Inscription> Update(int Id, Inscription entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(int Id)
    {
        throw new NotImplementedException();
    }
}