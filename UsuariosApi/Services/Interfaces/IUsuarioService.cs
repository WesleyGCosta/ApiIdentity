using UsuariosApi.Data.Dtos;

namespace UsuariosApi.Services.Interfaces
{
    public interface IUsuarioService
    {
        Task CadastrarUsuarioAsync(UsuarioDto usuario);
        Task<string> Login(LoginUsuarioDto login);
    }
}
