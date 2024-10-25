using Domain.Entity;

namespace Infra.Services;

public interface IUsuarioService
{
    Usuario GetUsuarioLogin(string email, string senha); 
}