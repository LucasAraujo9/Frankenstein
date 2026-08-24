using Frankenstein.Application.Entities;

namespace Frankenstein.Application.Repositories;

public interface IRecursoRepository
{
    void AddRecurso(Recurso recurso);
    void AddRecursos(IEnumerable<Recurso> recursos);
}
