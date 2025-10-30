using Institution.Application.Dtos;

namespace Institution.Application.Interfaces;

public interface IInscriptionService
{
    Task<IEnumerable<InscriptionDto>> GetAll();
    Task<InscriptionDto> Create(CourseCreationDto entity);
    Task<InscriptionDto> Update(int Id, CourseUpdateDto entity);
    Task<bool> Delete(int Id);
}