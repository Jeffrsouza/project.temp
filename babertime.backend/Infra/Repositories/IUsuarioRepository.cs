using Domain.Entity;

namespace Infra.Repositories;

public interface IUsuarioRepository
{
    Usuario GetUsuarioLogin(string email, string senha); 
}