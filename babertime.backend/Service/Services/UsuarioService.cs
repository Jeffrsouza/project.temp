using System.Runtime.CompilerServices;
using Domain.Entity;
using Infra.Repositories;

namespace Infra.Services;

public class UsuarioService : IUsuarioService
{
    private readonly IUsuarioRepository _repository;
    
    public UsuarioService(IUsuarioRepository repository)
    {
        _repository = repository;
    }
    
    public Usuario GetUsuarioLogin(string email, string senha)
    {
        return _repository.GetUsuarioLogin(email, senha);
    }
}