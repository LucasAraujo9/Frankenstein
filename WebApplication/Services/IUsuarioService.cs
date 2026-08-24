using Frankenstein.Application.Entities;

namespace Frankenstein.Application.Services;

public interface IUsuarioService
{
    void AddManyUsuarios(int quantidade);
    void AddUsuario(Usuario usuario);
    void AddUsuarios(List<Usuario> usuarios);
}
