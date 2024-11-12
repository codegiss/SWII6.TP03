using Microsoft.EntityFrameworkCore;
using SWII6.TP03.Models;

namespace SWII6.TP03.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Produtos> Produtos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Produtos>()
                .Property(p => p.Preco)
                .HasColumnType("DECIMAL(18,2)");
        }
    }
}
