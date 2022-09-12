using System;
using Impresoras3D.App.Dominio;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Impresoras3D.App.Persistencia
{
    public class RepositorioServicioTecnico : IRepositorioServicioTecnico
    {
        private readonly AppContext _appContext;
        public RepositorioServicioTecnico(AppContext appContext)
        {
            this._appContext = appContext;
        }
        public ServicioTecnico AddServicioTecnico(ServicioTecnico servicioTecnico)
        {
            var servicioTecnicoAdicionado = this._appContext.ServiciosTecnicos.Add(servicioTecnico);
            this._appContext.SaveChanges();
            return servicioTecnicoAdicionado.Entity;
        }
        public void DeleteServicioTecnico(int idServicioTecnico)
        {
            var servicioTecnico = this._appContext.ServiciosTecnicos.FirstOrDefault(
                s => s.Id == idServicioTecnico
            );
            if (servicioTecnico == null)
            {
                return;
            }
            this._appContext.ServiciosTecnicos.Remove(servicioTecnico);
            this._appContext.SaveChanges();
        }
        public ServicioTecnico getServicioTecnico(int idServicioTecnico)
        {
            var servicioTecnico = this._appContext.ServiciosTecnicos.FirstOrDefault(
                i => i.Id == idServicioTecnico
            );
            return servicioTecnico;
        }

        public IEnumerable<ServicioTecnico> GetAllServicioTecnico()
        {
            return this._appContext.ServiciosTecnicos;
        }

        public ServicioTecnico UpdateServicioTecnico(ServicioTecnico servicioTecnico)
        {
            var servicioTecnicoEncontrado = this._appContext.ServiciosTecnicos.FirstOrDefault(
                s => s.Id == servicioTecnico.Id
            );
            if (servicioTecnicoEncontrado != null)
            {
                servicioTecnicoEncontrado.Fecha = servicioTecnico.Fecha;
                servicioTecnicoEncontrado.MantenimientoComponentes =
                    servicioTecnico.MantenimientoComponentes;
                servicioTecnicoEncontrado.CambioComponentes = servicioTecnico.CambioComponentes;
                servicioTecnicoEncontrado.ImpresoraId = servicioTecnico.ImpresoraId;
                servicioTecnicoEncontrado.Impresora = servicioTecnico.Impresora;
                servicioTecnicoEncontrado.SoftwareId = servicioTecnico.SoftwareId;
                servicioTecnicoEncontrado.Software = servicioTecnico.Software;
                servicioTecnicoEncontrado.TecnicoId = servicioTecnico.TecnicoId;
                servicioTecnicoEncontrado.Tecnico = servicioTecnico.Tecnico;
                this._appContext.SaveChanges();
            }

            return servicioTecnicoEncontrado;
        }

        public IEnumerable<ServicioTecnico> GetServiciosTecnicosByImpresoraId(int impresoraId)
        {
            var serviciosTecnicosEncontrados = this._appContext.ServiciosTecnicos.FromSqlRaw(
                @"SELECT Id, Fecha, ImpresoraID, SoftwareId, TecnicoId FROM dbo.Servicio_Tecnico WHERE ImpresoraId = {0}", impresoraId).ToList();
            return serviciosTecnicosEncontrados;
        }
    }
}
