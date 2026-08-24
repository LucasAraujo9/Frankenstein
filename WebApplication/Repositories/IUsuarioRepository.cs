using Frankenstein.Application.Entities;

namespace Frankenstein.Application.Repositories;

public interface IUsuarioRepository
{
    void AddUsuario(Usuario usuario);
    void AddUsuarios(IEnumerable<Usuario> usuarios);
}
