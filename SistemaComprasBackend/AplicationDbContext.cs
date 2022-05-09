using Microsoft.EntityFrameworkCore;
using SistemaComprasBackend.Models;

namespace SistemaComprasBackend
{
    public class AplicationDbContext: DbContext
    {
     public    DbSet<Producto> Producto { get; set; }
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }
    }
}
