using System;
using Impresoras3D.App.Dominio;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Impresoras3D.App.Persistencia
{
    public class RepositorioSocioEmpresa : IRepositorioSocioEmpresa
    {
        private readonly AppContext _appContext;
        public RepositorioSocioEmpresa(AppContext appContext)
        {
            this._appContext = appContext;
        }
        public SocioEmpresa AddSocioEmpresa(SocioEmpresa socioEmpresa)
        {
            var socioEmpresaAdicionado = this._appContext.SocioEmpresas.Add(socioEmpresa);
            this._appContext.SaveChanges();
            return socioEmpresaAdicionado.Entity;
        }

        public void DeleteSocioEmpresa(int idSocioEmpresa)
        {
            var socioEmpresa = this._appContext.SocioEmpresas.FirstOrDefault(s => s.Id == idSocioEmpresa);
            if (socioEmpresa == null)
            {
                return;
            }
            this._appContext.SocioEmpresas.Remove(socioEmpresa);
            this._appContext.SaveChanges();
        }

        public SocioEmpresa getSocioEmpresa(int idSocioEmpresa)
        {
            var socioEmpresa = this._appContext.SocioEmpresas.FirstOrDefault(s => s.Id == idSocioEmpresa);
            return socioEmpresa;
        }

        public IEnumerable<SocioEmpresa> GetAllSocioEmpresa()
        {
            return this._appContext.SocioEmpresas;
        }



        public SocioEmpresa UpdateSocioEmpresa(SocioEmpresa socioEmpresa)
        {
            var socioEmpresaEncontrado = this._appContext.SocioEmpresas.FirstOrDefault(s => s.Id == socioEmpresa.Id);
            if (socioEmpresaEncontrado != null)
            {
                socioEmpresaEncontrado.Documento = socioEmpresa.Documento;
                socioEmpresaEncontrado.PrimerNombre = socioEmpresa.PrimerNombre;
                socioEmpresaEncontrado.SegundoNombre = socioEmpresa.SegundoNombre;
                socioEmpresaEncontrado.PrimerApellido = socioEmpresa.PrimerApellido;
                socioEmpresaEncontrado.SegundoApellido = socioEmpresa.SegundoApellido;
                socioEmpresaEncontrado.FechaNacimiento = socioEmpresa.FechaNacimiento;
                socioEmpresaEncontrado.telefono = socioEmpresa.telefono;
                this._appContext.SaveChanges();
            }
            return socioEmpresaEncontrado;
        }

        public SocioEmpresa getByDocument(int document)
        {
            var socioEmpresaEncontrado = this._appContext.SocioEmpresas.FromSqlRaw(
                @"SELECT Id, Documento, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, telefono FROM dbo.Socio_empresa WHERE documento = {0}", document
                ).FirstOrDefault();
            return socioEmpresaEncontrado;
        }
        public SocioEmpresa getByLogin(int document, string pass)
        {
            var socioEmpresaEncontrado = this._appContext.SocioEmpresas.FromSqlRaw(
                @"SELECT * FROM dbo.Socio_empresa WHERE Password = '" + pass + "' AND Documento = {0}", document
                ).FirstOrDefault();
            return socioEmpresaEncontrado;
        }
    }
}
