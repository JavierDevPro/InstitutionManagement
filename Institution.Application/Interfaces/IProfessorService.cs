using Institution.Application.Dtos;
using Institution.Domain.Entities;

namespace Institution.Application.Interfaces;

public interface IProfessorService
{
    Task<IEnumerable<ProfessorDto>> GetAll();
    Task<ProfessorDto> Create(ProfessorCreateDto entity);
    Task<ProfessorDto> Update(int Id, ProfessorUpdateDto entity);
    Task<bool> Delete(int Id);
}