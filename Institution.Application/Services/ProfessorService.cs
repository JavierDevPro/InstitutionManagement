using System.Runtime.InteropServices.JavaScript;
using Institution.Application.Dtos;
using Institution.Application.Interfaces;
using Institution.Domain.Entities;
using Institution.Domain.Interfaces;

namespace Institution.Application.Services;

public class ProfessorService : IProfessorService
{
    private readonly IRepository<Professor> _repository;

    public ProfessorService(IRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<ProfessorDto>> GetAll()
    {
        return await _repository.GetAll();
    }
}