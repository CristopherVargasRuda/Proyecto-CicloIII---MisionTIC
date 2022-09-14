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
        public ImpresoraComponente GetImpresoraComponenteByImpresoraIdTipoCabezal(int impresoraId)
        {
            var impresoraComponenteEncontrado = this._appContext.ImpresorasComponentes
                .FromSqlRaw(
                    @"SELECT ic.Id, ic.ComponenteId, ic.EstadoId, ic.ImpresoraId FROM dbo.Impresora_componente ic, dbo.Componente c WHERE c.Id = ic.ComponenteId AND LOWER(c.Nombre) like '%cabezal%' AND ic.ImpresoraId = {0} ORDER BY ic.Id DESC",
                    impresoraId
                ).FirstOrDefault();
            return impresoraComponenteEncontrado;
        }
        public ImpresoraComponente GetImpresoraComponenteByImpresoraIdTipoExtrusor(int impresoraId)
        {
            var impresoraComponenteEncontrado = this._appContext.ImpresorasComponentes
                .FromSqlRaw(
                    @"SELECT ic.Id, ic.ComponenteId, ic.EstadoId, ic.ImpresoraId FROM dbo.Impresora_componente ic, dbo.Componente c WHERE c.Id = ic.ComponenteId AND LOWER(c.Nombre) like '%extrusor%' AND ic.ImpresoraId = {0} ORDER BY ic.Id DESC", impresoraId
        ).FirstOrDefault();
            return impresoraComponenteEncontrado;
        }
        public ImpresoraComponente GetImpresoraComponenteByImpresoraIdTipoCama(int impresoraId)
        {
            var impresoraComponenteEncontrado = this._appContext.ImpresorasComponentes
                            .FromSqlRaw(
                                @"SELECT ic.Id, ic.ComponenteId, ic.EstadoId, ic.ImpresoraId FROM dbo.Impresora_componente ic, dbo.Componente c WHERE c.Id = ic.ComponenteId AND LOWER(c.Nombre) like '%cama%' AND ic.ImpresoraId = {0} ORDER BY ic.Id DESC",
                                impresoraId
                            )
                            .FirstOrDefault();
            return impresoraComponenteEncontrado;
        }
        public ImpresoraComponente GetImpresoraComponenteByImpresoraIdTipoFuente(int impresoraId)
        {
            var impresoraComponenteEncontrado = this._appContext.ImpresorasComponentes
                            .FromSqlRaw(
                                @"SELECT ic.Id, ic.ComponenteId, ic.EstadoId, ic.ImpresoraId FROM dbo.Impresora_componente ic, dbo.Componente c WHERE c.Id = ic.ComponenteId AND LOWER(c.Nombre) like '%fuente%' AND ic.ImpresoraId = {0} ORDER BY ic.Id DESC",
                                impresoraId
                            )
                            .FirstOrDefault();
            return impresoraComponenteEncontrado;
        }
    }
}
