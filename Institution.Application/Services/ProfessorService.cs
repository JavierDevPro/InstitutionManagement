using System.Runtime.InteropServices.JavaScript;
using Institution.Application.Dtos;
using Institution.Application.Interfaces;
using Institution.Domain.Entities;
using Institution.Domain.Interfaces;

namespace Institution.Application.Services;

public class ProfessorService : IProfessorService
{
    private readonly IRepository<Professor> _repository;

    public ProfessorService(IRepository<Professor> repository)
    {
        _repository = repository;
    }

    public ProfessorDto MapDto(Professor professor)
    {
        var Professor = new ProfessorDto
        {
            Id = professor.Id,
            Name = professor.Name,
            LastName = professor.LastName,
            Document = professor.Document,
            Email = professor.Email,
            PhoneNumber = professor.PhoneNumber,
            IsActive = professor.IsActive,
            Speciality = professor.Speciality,
            BirthDate = professor.BirthDate,
            DateCreation = professor.DateCreation,
            DateUpdate = professor.DateUpdate
        };
        return Professor;
    }
    
    public async Task<IEnumerable<ProfessorDto>> GetAll()
    {
        var professors = await _repository.GetAll();
        return professors.Select(MapDto);
    }

    public async Task<ProfessorDto> Create(ProfessorCreateDto entity)
    {
        var professorToCreate = new Professor
        {
            Name = entity.Name,
            LastName = entity.LastName,
            Document = entity.Document,
            Email = entity.Email,
            PhoneNumber = entity.PhoneNumber,
            IsActive = entity.IsActive,
            Speciality = entity.Speciality,
            BirthDate = entity.BirthDate,
            DateCreation = DateOnly.FromDateTime(DateTime.Now),
            DateUpdate = DateOnly.FromDateTime(DateTime.Now)
        };
        return MapDto(await _repository.Create(professorToCreate)); 
    }

    public async Task<ProfessorDto> Update(int Id, ProfessorUpdateDto entity)
    {
        var professorToUpdate = new Professor
        {
            Name = entity.Name,
            LastName = entity.LastName,
            Document = entity.Document,
            Email = entity.Email,
            PhoneNumber = entity.PhoneNumber,
            IsActive = entity.IsActive,
            Speciality = entity.Speciality,
            BirthDate = entity.BirthDate,
            DateUpdate = DateOnly.FromDateTime(DateTime.Now)
        };
        return MapDto(await _repository.Update(Id, professorToUpdate));
    }

    public async Task<bool> Delete(int Id)
    {
        return await _repository.Delete(Id);
    }
}