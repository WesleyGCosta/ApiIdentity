using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Data.Dtos;
using UsuariosApi.Services.Interfaces;

namespace UsuariosApi.Controllers
{
    [ApiController]
    [Route("[Controller]/[action]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuario;

        public UsuarioController(IUsuarioService usuario)
        {
            _usuario = usuario;
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarUsuario(UsuarioDto usuarioDto)
        {
            try
            {
                await _usuario.CadastrarUsuarioAsync(usuarioDto);
                return Ok("Usuario cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }                    
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginUsuarioDto login)
        {
            try
            {
               var token = await _usuario.Login(login);
                return Ok(token);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
    }
}
