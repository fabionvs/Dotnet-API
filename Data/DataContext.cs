using app.Models;
using Microsoft.EntityFrameworkCore;
namespace app.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }
        public DbSet<Contrato> Contratos { get; set; }

        public DbSet<Prestacao> Prestacoes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contrato>()
                .HasMany(c => c.Prestacoes)
                .WithOne(e => e.Contrato);
        }
    }
}