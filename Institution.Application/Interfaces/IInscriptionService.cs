using Institution.Application.Dtos;

namespace Institution.Application.Interfaces;

public interface IInscriptionService
{
    Task<IEnumerable<InscriptionDto>> GetAll();
    Task<InscriptionDto> Create(InscriptionCreationDto entity);
    Task<InscriptionDto> Update(int Id, InscriptionUpdateDto entity);
    Task<bool> Delete(int Id);
}