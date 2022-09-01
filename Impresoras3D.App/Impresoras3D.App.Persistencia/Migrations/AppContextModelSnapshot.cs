﻿// <auto-generated />
using System;
using Impresoras3D.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Impresoras3D.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Impresoras3D.App.Dominio.Auxiliar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Documento")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("PrimerApellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimerNombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoApellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoNombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Auxiliar");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.CambioComponente", b =>
                {
                    b.Property<int>("ServicioTecnicoId")
                        .HasColumnType("int");

                    b.Property<int>("ImpresoraComponenteId")
                        .HasColumnType("int");

                    b.HasKey("ServicioTecnicoId", "ImpresoraComponenteId");

                    b.HasIndex("ImpresoraComponenteId");

                    b.ToTable("Cambio_componente");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.Componente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Componente");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.CompraSeguro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("FechaCompra")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaVencimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImpresoraId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ImpresoraId1")
                        .HasColumnType("int");

                    b.Property<int>("SeguroId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ImpresoraId1");

                    b.HasIndex("SeguroId");

                    b.ToTable("Compra_seguro");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.Impresora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EstadoID")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Modelo")
                        .HasColumnType("int");

                    b.Property<int>("OperarioId")
                        .HasColumnType("int");

                    b.Property<string>("PaisOrigen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlacaInventario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoftwareId")
                        .HasColumnType("int");

                    b.Property<int>("TecnicoId")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VelocidaImpresion")
                        .HasColumnType("int");

                    b.Property<int>("VolumenImpresionX")
                        .HasColumnType("int");

                    b.Property<int>("VolumenImpresionY")
                        .HasColumnType("int");

                    b.Property<int>("VolumenImpresionZ")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EstadoID");

                    b.HasIndex("OperarioId");

                    b.HasIndex("SoftwareId");

                    b.HasIndex("TecnicoId");

                    b.ToTable("Impresora");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.ImpresoraComponente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ComponenteId")
                        .HasColumnType("int");

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.Property<string>("ImpresoraId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ComponenteId");

                    b.HasIndex("EstadoId");

                    b.ToTable("Impresora_componente");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.JefeOperaciones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Documento")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("PrimerApellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimerNombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoApellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoNombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Jefe_operaciones");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.MantenimientoComponente", b =>
                {
                    b.Property<int>("ServicioTecnicoId")
                        .HasColumnType("int");

                    b.Property<int>("ImpresoraComponenteId")
                        .HasColumnType("int");

                    b.HasKey("ServicioTecnicoId", "ImpresoraComponenteId");

                    b.HasIndex("ImpresoraComponenteId");

                    b.ToTable("Mantenimiento_componente");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.Operario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Documento")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("PrimerApellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimerNombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoApellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoNombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Operario");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.Seguro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Aseguradora")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Seguro");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.SeguroYTipoCubrimiento", b =>
                {
                    b.Property<int>("SeguroId")
                        .HasColumnType("int");

                    b.Property<int>("TipoCubrimientoId")
                        .HasColumnType("int");

                    b.HasKey("SeguroId", "TipoCubrimientoId");

                    b.HasIndex("TipoCubrimientoId");

                    b.ToTable("Seguro_tipoCubrimiento");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.ServicioTecnico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImpresoraId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ImpresoraId1")
                        .HasColumnType("int");

                    b.Property<int>("SoftwareId")
                        .HasColumnType("int");

                    b.Property<int>("TecnicoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ImpresoraId1");

                    b.HasIndex("SoftwareId");

                    b.HasIndex("TecnicoId");

                    b.ToTable("Servicio_Tecnico");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.SocioEmpresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Documento")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("PrimerApellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimerNombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoApellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoNombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Socio_empresa");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.Software", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.Property<string>("Licencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.ToTable("Software");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.Tecnico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Documento")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("NivelEstudios")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimerApellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimerNombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoApellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoNombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tecnico");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.TipoCubrimiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tipo_cubrimiento");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.CambioComponente", b =>
                {
                    b.HasOne("Impresoras3D.App.Dominio.ImpresoraComponente", "ImpresoraComponente")
                        .WithMany("CambioComponentes")
                        .HasForeignKey("ImpresoraComponenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Impresoras3D.App.Dominio.ServicioTecnico", "ServicioTecnico")
                        .WithMany("CambioComponentes")
                        .HasForeignKey("ServicioTecnicoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ImpresoraComponente");

                    b.Navigation("ServicioTecnico");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.CompraSeguro", b =>
                {
                    b.HasOne("Impresoras3D.App.Dominio.Impresora", "Impresora")
                        .WithMany("CompraSeguros")
                        .HasForeignKey("ImpresoraId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Impresoras3D.App.Dominio.Seguro", "Seguro")
                        .WithMany("CompraSeguros")
                        .HasForeignKey("SeguroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Impresora");

                    b.Navigation("Seguro");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.Impresora", b =>
                {
                    b.HasOne("Impresoras3D.App.Dominio.Estado", "Estado")
                        .WithMany("Impresoras")
                        .HasForeignKey("EstadoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Impresoras3D.App.Dominio.Operario", "Operario")
                        .WithMany("Impresoras")
                        .HasForeignKey("OperarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Impresoras3D.App.Dominio.Software", "Software")
                        .WithMany("Impresoras")
                        .HasForeignKey("SoftwareId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Impresoras3D.App.Dominio.Tecnico", "Tecnico")
                        .WithMany("Impresoras")
                        .HasForeignKey("TecnicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");

                    b.Navigation("Operario");

                    b.Navigation("Software");

                    b.Navigation("Tecnico");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.ImpresoraComponente", b =>
                {
                    b.HasOne("Impresoras3D.App.Dominio.Componente", "Componente")
                        .WithMany("ImpresoraComponentes")
                        .HasForeignKey("ComponenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Impresoras3D.App.Dominio.Estado", "Estado")
                        .WithMany("ImpresoraComponentes")
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Componente");

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.MantenimientoComponente", b =>
                {
                    b.HasOne("Impresoras3D.App.Dominio.ImpresoraComponente", "ImpresoraComponente")
                        .WithMany("MantenimientoComponentes")
                        .HasForeignKey("ImpresoraComponenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Impresoras3D.App.Dominio.ServicioTecnico", "ServicioTecnico")
                        .WithMany("MantenimientoComponentes")
                        .HasForeignKey("ServicioTecnicoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ImpresoraComponente");

                    b.Navigation("ServicioTecnico");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.SeguroYTipoCubrimiento", b =>
                {
                    b.HasOne("Impresoras3D.App.Dominio.Seguro", "Seguro")
                        .WithMany("SegurosYTipoCubrimiento")
                        .HasForeignKey("SeguroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Impresoras3D.App.Dominio.TipoCubrimiento", "TipoCubrimiento")
                        .WithMany("SeguroYTipoCubrimiento")
                        .HasForeignKey("TipoCubrimientoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Seguro");

                    b.Navigation("TipoCubrimiento");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.ServicioTecnico", b =>
                {
                    b.HasOne("Impresoras3D.App.Dominio.Impresora", "Impresora")
                        .WithMany("ServiciosTecnicos")
                        .HasForeignKey("ImpresoraId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Impresoras3D.App.Dominio.Software", "Software")
                        .WithMany("ServiciosTecnicos")
                        .HasForeignKey("SoftwareId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Impresoras3D.App.Dominio.Tecnico", "Tecnico")
                        .WithMany("ServiciosTecnicos")
                        .HasForeignKey("TecnicoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Impresora");

                    b.Navigation("Software");

                    b.Navigation("Tecnico");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.Software", b =>
                {
                    b.HasOne("Impresoras3D.App.Dominio.Estado", "Estado")
                        .WithMany("Softwares")
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.Componente", b =>
                {
                    b.Navigation("ImpresoraComponentes");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.Estado", b =>
                {
                    b.Navigation("ImpresoraComponentes");

                    b.Navigation("Impresoras");

                    b.Navigation("Softwares");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.Impresora", b =>
                {
                    b.Navigation("CompraSeguros");

                    b.Navigation("ServiciosTecnicos");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.ImpresoraComponente", b =>
                {
                    b.Navigation("CambioComponentes");

                    b.Navigation("MantenimientoComponentes");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.Operario", b =>
                {
                    b.Navigation("Impresoras");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.Seguro", b =>
                {
                    b.Navigation("CompraSeguros");

                    b.Navigation("SegurosYTipoCubrimiento");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.ServicioTecnico", b =>
                {
                    b.Navigation("CambioComponentes");

                    b.Navigation("MantenimientoComponentes");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.Software", b =>
                {
                    b.Navigation("Impresoras");

                    b.Navigation("ServiciosTecnicos");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.Tecnico", b =>
                {
                    b.Navigation("Impresoras");

                    b.Navigation("ServiciosTecnicos");
                });

            modelBuilder.Entity("Impresoras3D.App.Dominio.TipoCubrimiento", b =>
                {
                    b.Navigation("SeguroYTipoCubrimiento");
                });
#pragma warning restore 612, 618
        }
    }
}
