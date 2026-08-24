using AutoMapper;
using Bogus;
using Frankenstein.Application.DTOs;
using Frankenstein.Application.Entities;
using Frankenstein.Application.Repositories;

namespace Frankenstein.Application.Services;

public class UsuarioService : IUsuarioService
{
    private readonly IUsuarioRepository _usuarioRepository;
    private readonly IMapper _mapper;

    public UsuarioService(IUsuarioRepository usuarioRepository, IMapper mapper)
    {
        _usuarioRepository = usuarioRepository;
        _mapper = mapper;
    }

    public void AddManyUsuarios(int quantidade)
    {
        var usuarios = new Faker<UsuarioDTO>("pt_BR")
            .RuleFor(u => u.Nome, f => f.Name.FullName())
            .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.Nome));

        List<UsuarioDTO> listaUsuarios = usuarios.Generate(quantidade);

        List<Usuario> listaUsuariosEntidades = _mapper.Map<List<Usuario>>(listaUsuarios);

        AddUsuarios(listaUsuariosEntidades);
    }

    #region Base
    public void AddUsuario(Usuario usuario)
    {
        _usuarioRepository.AddUsuario(usuario);
    }

    public void AddUsuarios(List<Usuario> usuarios)
    {
        _usuarioRepository.AddUsuarios(usuarios);
    }
    #endregion
}
