using System;
using Impresoras3D.App.Dominio;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Impresoras3D.App.Persistencia
{
    public class RepositorioImpresora : IRepositorioImpresora
    {
        private readonly AppContext _appContext;

        public RepositorioImpresora(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public Impresora AddImpresora(Impresora impresora)
        {
            var impresoraAdicionada = this._appContext.Impresoras.Add(impresora);

            this._appContext.SaveChanges();

            return impresoraAdicionada.Entity;
        }

        public void DeleteImpresora(int idImpresora)
        {
            var impresora = this._appContext.Impresoras.FirstOrDefault(i => i.Id == idImpresora);

            if (impresora == null)
            {
                return;
            }

            this._appContext.Impresoras.Remove(impresora);

            this._appContext.SaveChanges();
        }

        public Impresora getImpresora(int idImpresora)
        {
            var impresora = this._appContext.Impresoras.FirstOrDefault(i => i.Id == idImpresora);

            return impresora;
        }

        public IEnumerable<Impresora> GetAllImpresora()
        {
            return this._appContext.Impresoras;
        }

        public Impresora UpdateImpresora(Impresora impresora)
        {
            var impresoraEncontrada = this._appContext.Impresoras.FirstOrDefault(
                c => c.Id == impresora.Id
            );

            if (impresoraEncontrada != null)
            {
                impresoraEncontrada.PlacaInventario = impresora.PlacaInventario;

                impresoraEncontrada.Tipo = impresora.Tipo;

                impresoraEncontrada.Marca = impresora.Marca;

                impresoraEncontrada.Modelo = impresora.Modelo;

                impresoraEncontrada.VelocidaImpresion = impresora.VelocidaImpresion;

                impresoraEncontrada.VolumenImpresionX = impresora.VolumenImpresionX;

                impresoraEncontrada.VolumenImpresionY = impresora.VolumenImpresionY;

                impresoraEncontrada.VolumenImpresionZ = impresora.VolumenImpresionZ;

                impresoraEncontrada.PaisOrigen = impresora.PaisOrigen;

                impresoraEncontrada.ServiciosTecnicos = impresora.ServiciosTecnicos;

                impresoraEncontrada.EstadoID = impresora.EstadoID;

                impresoraEncontrada.CompraSeguros = impresora.CompraSeguros;

                impresoraEncontrada.OperarioId = impresora.OperarioId;

                impresoraEncontrada.Operario = impresora.Operario;

                impresoraEncontrada.TecnicoId = impresora.TecnicoId;

                impresoraEncontrada.Tecnico = impresora.Tecnico;

                impresoraEncontrada.SoftwareId = impresora.SoftwareId;

                impresoraEncontrada.Software = impresora.Software;

                this._appContext.SaveChanges();
            }
            return impresoraEncontrada;
        }

        public Impresora getByPlaca(string placaImpresora)
        {
            var impresoraEncontrada = this._appContext.Impresoras
                .FromSqlRaw(
                    @"SELECT Id, PlacaInventario, Tipo, Marca, Modelo, VelocidaImpresion, VolumenImpresionX, VolumenImpresionY, VolumenImpresionZ, PaisOrigen, EstadoID, OperarioId, TecnicoId, SoftwareId FROM dbo.Impresora i WHERE i.PlacaInventario = {0}",
                    placaImpresora
                )
                .FirstOrDefault();
            return impresoraEncontrada;
        }
        public IEnumerable<Impresora> getImpresorasByTecnico(int tecnicoId)
        {
            var impresoraEncontrada = this._appContext.Impresoras
                            .FromSqlRaw(
                                @"SELECT i.Id, i.PlacaInventario, i.Tipo, i.Marca, i.Modelo, i.VelocidaImpresion, i.VolumenImpresionX, i.VolumenImpresionY, i.VolumenImpresionZ, i.PaisOrigen, i.EstadoID, i.OperarioId, i.TecnicoId, i.SoftwareId FROM dbo.Impresora i WHERE i.TecnicoId = {0}",
                                tecnicoId
                            )
                            .ToList();
            return impresoraEncontrada;
        }

        public IEnumerable<Impresora> getImpresorasByOperario(int operarioId)
        {
            var impresoraEncontrada = this._appContext.Impresoras
                            .FromSqlRaw(
                                @"SELECT i.Id, i.PlacaInventario, i.Tipo, i.Marca, i.Modelo, i.VelocidaImpresion, i.VolumenImpresionX, i.VolumenImpresionY, i.VolumenImpresionZ, i.PaisOrigen, i.EstadoID, i.OperarioId, i.TecnicoId, i.SoftwareId FROM dbo.Impresora i WHERE i.OperarioId = {0}",
                                operarioId
                            )
                            .ToList();
            return impresoraEncontrada;
        }
    }
}
