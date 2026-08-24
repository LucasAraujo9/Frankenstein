using Frankenstein.Application.Entities;

namespace Frankenstein.Application.Repositories;

public class RecursoRepository : IRecursoRepository
{
    private readonly AppDbContext _context;
    public RecursoRepository(AppDbContext context)
    {
        _context = context;
    }

    public void AddRecurso(Recurso recurso)
    {
        _context.Recursos.Add(recurso);
        _context.SaveChanges();
    }

    public void AddRecursos(IEnumerable<Recurso> recursos)
    {
        _context.Recursos.AddRange(recursos);
        _context.SaveChanges();
    }
}
