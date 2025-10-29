namespace Institution.Application.Interfaces;

public interface IMapperService<T> where T: class
{
    Task<T> MapEntity(T entity);
}