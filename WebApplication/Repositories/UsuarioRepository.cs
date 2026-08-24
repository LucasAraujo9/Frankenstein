using Frankenstein.Application.Entities;

namespace Frankenstein.Application.Repositories;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly AppDbContext _context;

    public UsuarioRepository(AppDbContext context)
    {
        _context = context;
    }

    public void AddUsuario(Usuario usuario)
    {
        _context.Usuarios.Add(usuario);
        _context.SaveChanges();
    }

    public void AddUsuarios(IEnumerable<Usuario> usuarios)
    {
        _context.Usuarios.AddRange(usuarios);
        _context.SaveChanges();
    }
}
