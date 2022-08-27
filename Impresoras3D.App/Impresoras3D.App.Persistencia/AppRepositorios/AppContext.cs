using System;

using Microsoft.EntityFrameworkCore;

using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{

    public class AppContext : DbContext
    {
        //Seguros
        public DbSet<Seguro> Seguro { get; set; }

        public DbSet<TipoCubrimiento> TipoCubrimiento { get; set; }

        public DbSet<SeguroYTipoCubrimiento> SeguroYTipoCubrimiento { get; set; }

        public DbSet<CompraSeguro> CompraSeguro { get; set; }

        //Personas (INCOMPLETO TECNICO Y OPERARIO!)

        public DbSet<JefeOperaciones> JefeOperaciones { get; set; } 

        public DbSet<Auxiliar> Auxiliar { get; set; } 

        public DbSet<SocioEmpresa> SocioEmpresa { get; set; } 

        public DbSet<Operario> Operario { get; set; } //La tabla de impresoras está comentada, cuando se agregue impresoras a la base de datos descomentar!

        public DbSet<Tecnico> Tecnico { get; set; } //La tabla de impresoras y servicio tecnico estan comentadas de igual forma descomentar cuando esten disponibles en la base de datos!


        //conexion base de datos
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
