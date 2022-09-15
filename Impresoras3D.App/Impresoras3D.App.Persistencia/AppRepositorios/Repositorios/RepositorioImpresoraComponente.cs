using System;
using Impresoras3D.App.Dominio;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Impresoras3D.App.Persistencia
{
    public class RepositorioImpresoraComponente : IRepositorioImpresoraComponente
    {
        private readonly AppContext _appContext;

        public RepositorioImpresoraComponente(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public ImpresoraComponente AddImpresoraComponente(ImpresoraComponente impresoraComponente)
        {
            var impresoraComponenteAdicionado = this._appContext.ImpresorasComponentes.Add(impresoraComponente);
            this._appContext.SaveChanges();
            return impresoraComponenteAdicionado.Entity;
        }

        public void DeleteImpresoraComponente(int idImpresoraComponente)
        {
            var impresoraComponente = this._appContext.ImpresorasComponentes.FirstOrDefault(i => i.Id == idImpresoraComponente);
            if (impresoraComponente == null)
            {
                return;
            }
            this._appContext.ImpresorasComponentes.Remove(impresoraComponente);
            this._appContext.SaveChanges();
        }

        public ImpresoraComponente getImpresoraComponente(int idImpresoraComponente)
        {
            var impresoraComponente = this._appContext.ImpresorasComponentes.FirstOrDefault(i => i.Id == idImpresoraComponente);
            return impresoraComponente;
        }

        public IEnumerable<ImpresoraComponente> GetAllImpresoraComponente()
        {
            return this._appContext.ImpresorasComponentes;
        }

        public ImpresoraComponente UpdateImpresoraComponente(ImpresoraComponente impresoraComponente)
        {
            var impresoraComponenteEncontrado = this._appContext.ImpresorasComponentes.FirstOrDefault(
                i => i.Id == impresoraComponente.Id
            );
            if (impresoraComponenteEncontrado != null)
            {
                impresoraComponenteEncontrado.ImpresoraId = impresoraComponente.ImpresoraId;
                impresoraComponenteEncontrado.ComponenteId = impresoraComponente.ComponenteId;
                impresoraComponenteEncontrado.Componente = impresoraComponente.Componente;
                impresoraComponenteEncontrado.EstadoId = impresoraComponente.EstadoId;
                impresoraComponenteEncontrado.Estado = impresoraComponente.Estado;
                impresoraComponenteEncontrado.MantenimientoComponentes = impresoraComponente.MantenimientoComponentes;
                impresoraComponenteEncontrado.CambioComponentes = impresoraComponente.CambioComponentes;
                this._appContext.SaveChanges();
            }
            return impresoraComponenteEncontrado;
        }
        public IEnumerable<ImpresoraComponente> GetImpresoraComponenteByImpresoraIdTipoCabezal(int impresoraId)
        {
            var impresoraComponentesEncontrados = this._appContext.ImpresorasComponentes.FromSqlRaw(
                @"select ic.Id, ic.ImpresoraId, ic.ComponenteId, ic.EstadoId from dbo.Impresora_componente ic, dbo.Componente c where ic.ComponenteId = c.Id AND LOWER(c.Nombre) like '%cabezal%' AND ic.ImpresoraId = {0}", impresoraId).ToList();
            return impresoraComponentesEncontrados;
        }
        public IEnumerable<ImpresoraComponente> GetImpresoraComponenteByImpresoraIdTipoExtrusor(int impresoraId)
        {
            var impresoraComponentesEncontrados = this._appContext.ImpresorasComponentes.FromSqlRaw(
                @"select ic.Id, ic.ImpresoraId, ic.ComponenteId, ic.EstadoId from dbo.Impresora_componente ic, dbo.Componente c where ic.ComponenteId = c.Id AND LOWER(c.Nombre) like '%extrusor%' AND ic.ImpresoraId = {0}", impresoraId).ToList();
            return impresoraComponentesEncontrados;
        }
        public IEnumerable<ImpresoraComponente> GetImpresoraComponenteByImpresoraIdTipoCama(int impresoraId)
        {
            var impresoraComponentesEncontrados = this._appContext.ImpresorasComponentes.FromSqlRaw(
                @"select ic.Id, ic.ImpresoraId, ic.ComponenteId, ic.EstadoId from dbo.Impresora_componente ic, dbo.Componente c where ic.ComponenteId = c.Id AND LOWER(c.Nombre) like '%cama%' AND ic.ImpresoraId = {0}", impresoraId).ToList();
            return impresoraComponentesEncontrados;
        }
        public IEnumerable<ImpresoraComponente> GetImpresoraComponenteByImpresoraIdTipoFuente(int impresoraId)
        {
            var impresoraComponentesEncontrados = this._appContext.ImpresorasComponentes.FromSqlRaw(
                @"select ic.Id, ic.ImpresoraId, ic.ComponenteId, ic.EstadoId from dbo.Impresora_componente ic, dbo.Componente c where ic.ComponenteId = c.Id AND LOWER(c.Nombre) like '%fuente%' AND ic.ImpresoraId = {0}", impresoraId).ToList();
            return impresoraComponentesEncontrados;
        }
    }
}
