using Microsoft.EntityFrameworkCore;

namespace CRUDPersonas.Data
{
    public class OracleDbContext : DbContext
    {
        public OracleDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Persona> Persona { get; set; }
    }
}
