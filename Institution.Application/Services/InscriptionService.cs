using Institution.Application.Dtos;
using Institution.Application.Interfaces;
using Institution.Domain.Entities;
using Institution.Domain.Interfaces;

namespace Institution.Application.Services;

public class InscriptionService : IInscriptionService
{
    private readonly IRepository<Inscription> _repository;

    public InscriptionService(IRepository<Inscription> repository)
    {
        _repository = repository;
    }

    public InscriptionDto MapDto(Inscription inscription)
    {
        var Inscription = new InscriptionDto
        {
            Id = inscription.Id,
            StudentId = inscription.StudentId,
            CourseId = inscription.CourseId,
            DateCreation = inscription.DateCreation,
            DateUpdate = inscription.DateUpdate
        };
        return Inscription;
    }
    
    public async Task<IEnumerable<InscriptionDto>> GetAll()
    {
        var inscription = await _repository.GetAll();
        return inscription.Select(MapDto);
    }

    public async Task<InscriptionDto> Create(InscriptionCreationDto entity)
    {
        var incriptionToCreate = new Inscription
        {
            StudentId = entity.StudentId,
            CourseId = entity.CourseId,
            DateCreation = DateOnly.FromDateTime(DateTime.Now),
            DateUpdate = DateOnly.FromDateTime(DateTime.Now)
        };
        return MapDto(await _repository.Create(incriptionToCreate));
    }

    public async Task<InscriptionDto> Update(int Id, InscriptionUpdateDto entity)
    {
        var inscriptionToUpdate = new Inscription
        {
            StudentId = entity.StudentId,
            CourseId = entity.CourseId,
            DateUpdate = entity.DateUpdate
        };
        return MapDto(await _repository.Update(Id , inscriptionToUpdate));
    }

    public async Task<bool> Delete(int Id)
    {
        return await _repository.Delete(Id);
    }
}