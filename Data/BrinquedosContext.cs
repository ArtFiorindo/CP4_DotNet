using Microsoft.EntityFrameworkCore;
using BrinquedosApi.Models;

namespace BrinquedosApi.Data
{
    public class BrinquedosContext : DbContext
    {
        public BrinquedosContext(DbContextOptions<BrinquedosContext> options) : base(options) { }

        public DbSet<Brinquedo> Brinquedos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brinquedo>()
                .Property(b => b.Preco)
                .HasPrecision(18, 2);  // Define precisão total 18 dígitos, 2 casas decimais

            modelBuilder.Entity<Brinquedo>()
                .HasKey(b => b.Id_brinquedo);
        }
    }
}