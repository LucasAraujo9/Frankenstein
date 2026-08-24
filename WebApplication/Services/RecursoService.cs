using Frankenstein.Application.Entities;
using Frankenstein.Application.Repositories;

namespace Frankenstein.Application.Services;

public class RecursoService : IRecursoService
{
    private readonly IRecursoRepository _recursoRepository;

    public RecursoService(IRecursoRepository recursoRepository)
    {
        _recursoRepository = recursoRepository;
    }

    public void AddUsuario(Recurso recurso)
    {
        _recursoRepository.AddRecurso(recurso);
    }

    public void AddUsuarios(IEnumerable<Recurso> recursos)
    {
        _recursoRepository.AddRecursos(recursos);
    }
}
