using System;

using Microsoft.EntityFrameworkCore;

using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{

    public class AppContext : DbContext
    {
        public DbSet<Auxiliar> Auxiliares { get; set; }
        public DbSet<CambioComponente> CambioComponentes { get; set; }
        public DbSet<Componente> Componentes { get; set; }
        public DbSet<CompraSeguro> CompraSeguros { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Impresora> Impresoras { get; set; }
        public DbSet<ImpresoraComponente> ImpresorasComponentes { get; set; }
        public DbSet<JefeOperaciones> JefeOperaciones { get; set; }
        public DbSet<MantenimientoComponente> MantenimientoComponentes { get; set; }
        public DbSet<Operario> Operarios { get; set; }
        public DbSet<Seguro> Seguros { get; set; }
        public DbSet<SeguroYTipoCubrimiento> SeguroYTipoCubrimientos { get; set; }
        public DbSet<ServicioTecnico> ServiciosTecnicos { get; set; }
        public DbSet<SocioEmpresa> SocioEmpresas { get; set; }
        public DbSet<Software> Softwares { get; set; }
        public DbSet<Tecnico> Tecnicos { get; set; }
        public DbSet<TipoCubrimiento> TipoCubrimientos { get; set; }

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

        //Se sobreescribe el metodo de haskey para crea las llaves compuestas:
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<SeguroYTipoCubrimiento>()
                .HasKey(s => new { s.SeguroId, s.TipoCubrimientoId });
            modelBuilder
                .Entity<CambioComponente>()
                .HasKey(c => new { c.ServicioTecnicoId, c.ImpresoraComponenteId });
            modelBuilder
                .Entity<MantenimientoComponente>()
                .HasKey(m => new { m.ServicioTecnicoId, m.ImpresoraComponenteId });

          
            

            modelBuilder.Entity<ServicioTecnico>()
            .HasMany(s => s.CambioComponentes)
            .WithOne(c => c.ServicioTecnico)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ServicioTecnico>()
            .HasMany(m => m.MantenimientoComponentes)
            .WithOne(c => c.ServicioTecnico)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Software>()
            .HasMany(s => s.Impresoras)
            .WithOne(i => i.Software)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Tecnico>()
            .HasMany(t => t.ServiciosTecnicos)
            .WithOne(st => st.Tecnico)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Software>()
            .HasMany(s => s.ServiciosTecnicos)
            .WithOne(st => st.Software)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
