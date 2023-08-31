using System.ComponentModel.DataAnnotations;

namespace UsuariosApi.Data.Dtos
{
    public class UsuarioDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }


        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string RePassword { get; set; }
    }
}
