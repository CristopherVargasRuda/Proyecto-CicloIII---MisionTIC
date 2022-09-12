using System;
using Impresoras3D.App.Dominio;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Impresoras3D.App.Persistencia
{
    public class RepositorioEstado : IRepositorioEstado
    {
        private readonly AppContext _appContext;

        public RepositorioEstado(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public Estado AddEstado(Estado estado)
        {
            var estadoAdicionado = this._appContext.Estados.Add(estado);

            this._appContext.SaveChanges();

            return estadoAdicionado.Entity;
        }

        public void DeleteEstado(int? idEstado)
        {
            var estado = this._appContext.Estados.FirstOrDefault(e => e.Id == idEstado);
            if (estado == null)
            {
                return;
            }
            this._appContext.Estados.Remove(estado);
            this._appContext.SaveChanges();
        }

        public Estado getEstado(int? idEstado)
        {
            var estado = this._appContext.Estados.FirstOrDefault(s => s.Id == idEstado);
            return estado;
        }
        public IEnumerable<Estado> GetAllEstado()
        {
            return this._appContext.Estados;
        }
        public Estado UpdateEstado(Estado estado)
        {
            var estadoEncontrado = this._appContext.Estados.FirstOrDefault(
                e => e.Id == estado.Id
            );
            if (estadoEncontrado != null)
            {
                estadoEncontrado.Nombre = estado.Nombre;
                estadoEncontrado.Impresoras = estado.Impresoras;
                estadoEncontrado.ImpresoraComponentes = estado.ImpresoraComponentes;
                estadoEncontrado.Softwares = estado.Softwares;
                this._appContext.SaveChanges();
            }
            return estadoEncontrado;
        }
        public IEnumerable<Estado> GetImpresoraEstados()
        {
            var estados = this._appContext.Estados.FromSqlRaw(
                    @"SELECT * FROM dbo.Estado e WHERE LOWER(e.Nombre) like '%impresora -%'"
                    ).ToList();
            return estados;
        }
        public IEnumerable<Estado> GetSoftwareEstados()
        {
            var estados = this._appContext.Estados.FromSqlRaw(
                    @"SELECT * FROM dbo.Estado e WHERE LOWER(e.Nombre) like '%software -%'"
                    ).ToList();
            return estados;
        }
        public IEnumerable<Estado> GetComponenteEstados()
        {
            var estados = this._appContext.Estados.FromSqlRaw(
                    @"SELECT * FROM dbo.Estado e WHERE LOWER(e.Nombre) like '%cabezal -%' OR LOWER(e.Nombre) like '%extrusor -%' OR LOWER(e.Nombre) like '%cama -%'"
                    ).ToList();
            return estados;
        }
    }
}
