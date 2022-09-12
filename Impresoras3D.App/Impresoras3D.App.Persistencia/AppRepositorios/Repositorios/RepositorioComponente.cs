using System;
using Impresoras3D.App.Dominio;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Impresoras3D.App.Persistencia
{
    public class RepositorioComponente : IRepositorioComponente
    {
        private readonly AppContext _appContext;

        public RepositorioComponente(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public Componente AddComponente(Componente componente)
        {
            var componenteAdicionado = this._appContext.Componentes.Add(componente);
            this._appContext.SaveChanges();
            return componenteAdicionado.Entity;
        }

        public void DeleteComponente(int idcomponente)
        {
            var componente = this._appContext.Componentes.FirstOrDefault(c => c.Id == idcomponente);
            if (componente == null)
            {
                return;
            }

            this._appContext.Componentes.Remove(componente);
            this._appContext.SaveChanges();
        }

        public Componente getComponente(int idcomponente)
        {
            var componente = this._appContext.Componentes.FirstOrDefault(c => c.Id == idcomponente);
            return componente;
        }

        public IEnumerable<Componente> GetAllComponente()
        {
            return this._appContext.Componentes;
        }

        public Componente UpdateComponente(Componente componente)
        {
            var componenteEncontrado = this._appContext.Componentes.FirstOrDefault(
                c => c.Id == componente.Id
            );
            if (componenteEncontrado != null)
            {
                componenteEncontrado.Nombre = componente.Nombre;
                componenteEncontrado.Descripcion = componente.Descripcion;
                componenteEncontrado.ImpresoraComponentes = componente.ImpresoraComponentes;
                this._appContext.SaveChanges();
            }
            return componenteEncontrado;
        }
        public IEnumerable<Componente> getCabezarComponentes()
        {
            var componentesObtenidos = this._appContext.Componentes.FromSqlRaw(
                    @"SELECT Id, Nombre, Descripcion FROM dbo.Componente c WHERE LOWER(c.Nombre) like  '%cabezal%'"
                    ).ToList();
            return componentesObtenidos;
        }
        public IEnumerable<Componente> getExtrusorComponentes()
        {
            var componentesObtenidos = this._appContext.Componentes.FromSqlRaw(
                    @"SELECT Id, Nombre, Descripcion FROM dbo.Componente c WHERE LOWER(c.Nombre) like  '%extrusor%'"
                    ).ToList();
            return componentesObtenidos;
        }
        public IEnumerable<Componente> getCamaComponentes()
        {
            var componentesObtenidos = this._appContext.Componentes.FromSqlRaw(
                    @"SELECT Id, Nombre, Descripcion FROM dbo.Componente c WHERE LOWER(c.Nombre) like  '%cama%'"
                    ).ToList();
            return componentesObtenidos;
        }
        public IEnumerable<Componente> getFuenteComponentes()
        {
            var componentesObtenidos = this._appContext.Componentes.FromSqlRaw(
                    @"SELECT Id, Nombre, Descripcion FROM dbo.Componente c WHERE LOWER(c.Nombre) like  '%fuente%'"
                    ).ToList();
            return componentesObtenidos;
        }

        public IEnumerable<Componente> getComponentesByImpresoraId(int impresoraId) {
            var componentesObtenidos = this._appContext.Componentes.FromSqlRaw(
                    @"SELECT c.Id, c.Nombre, c.Descripcion FROM dbo.Componente c, dbo.Impresora i, dbo.Impresora_componente ic WHERE c.Id = ic.ComponenteId AND i.Id = ic.ImpresoraId AND i.Id = {0} ORDER BY ic.Id DESC;", impresoraId
                    ).ToList();
            return componentesObtenidos;
        }

        public IEnumerable<Componente> getComponentesMantenimientoByServicioId(int servicioId)
        {
            var componentesObtenidos = this._appContext.Componentes.FromSqlRaw(
                    @"SELECT c.Id, c.Nombre, c.Descripcion FROM dbo.Componente c, dbo.Impresora_componente ic, dbo.Mantenimiento_componente mc WHERE c.id = ic.ComponenteId AND ic.Id = mc.ImpresoraComponenteId AND mc.ServicioTecnicoId = {0}", servicioId
                    ).ToList();
            return componentesObtenidos;
        }
        public IEnumerable<Componente> getComponentesCambioByServicioId(int servicioId)
        {
            var componentesObtenidos = this._appContext.Componentes.FromSqlRaw(
                    @"SELECT c.Id, c.Nombre, c.Descripcion FROM dbo.Componente c, dbo.Impresora_componente ic, dbo.Cambio_componente cc WHERE c.id = ic.ComponenteId AND ic.Id = cc.ImpresoraComponenteId AND cc.ServicioTecnicoId = {0}", servicioId
                    ).ToList();
            return componentesObtenidos;
        }
    }
}
