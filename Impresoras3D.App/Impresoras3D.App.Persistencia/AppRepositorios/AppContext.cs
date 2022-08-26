using System;

using Microsoft.EntityFrameworkCore;

using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Seguro> Seguros { get; set; }

        public DbSet<TipoCubrimiento> TipoCubrimientos { get; set; }

        public DbSet<SeguroYTipoCubrimiento> SeguroYTipoCubrimientos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Data Source =(localdb)\\MSSQLLocalDB;Initial Catalog= ImpresoraData"
                );
            }
        }

        //Se sobreescribe el metodo de haskey para crea la llave compuesta:

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<SeguroYTipoCubrimiento>()
                .HasKey(s => new { s.SeguroId, s.TipoCubrimientoId });
        }
    }
}
