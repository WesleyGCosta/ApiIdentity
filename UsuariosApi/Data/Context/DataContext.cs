using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UsuariosApi.Models;

namespace UsuariosApi.Data.Context
{
    public class DataContext : IdentityDbContext<Usuario>
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<Usuario> Usuarios { get; set; }
    }
}
