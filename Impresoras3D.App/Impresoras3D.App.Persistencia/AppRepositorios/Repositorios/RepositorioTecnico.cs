using System;
using Impresoras3D.App.Dominio;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Impresoras3D.App.Persistencia
{
    public class RepositorioTecnico : IRepositorioTecnico
    {
        private readonly AppContext _appContext;

        public RepositorioTecnico(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public Tecnico AddTecnico(Tecnico tecnico)
        {
            var tecnicoAdicionado = this._appContext.Tecnicos.Add(tecnico);
            this._appContext.SaveChanges();
            return tecnicoAdicionado.Entity;
        }

        public void DeleteTecnico(int idTecnico)
        {
            var tecnico = this._appContext.Tecnicos.FirstOrDefault(t => t.Id == idTecnico);
            if (tecnico == null)
            {
                return;
            }
            this._appContext.Tecnicos.Remove(tecnico);
            this._appContext.SaveChanges();
        }

        public Tecnico getTecnico(int? idTecnico)
        {
            var tecnico = this._appContext.Tecnicos.FirstOrDefault(t => t.Id == idTecnico);
            return tecnico;
        }

        public IEnumerable<Tecnico> GetAllTecnico()
        {
            return this._appContext.Tecnicos;
        }

        public Tecnico UpdateTecnico(Tecnico tecnico)
        {
            var tecnicoEncontrado = this._appContext.Tecnicos.FirstOrDefault(
                t => t.Id == tecnico.Id
            );

            if (tecnicoEncontrado != null)
            {
                tecnicoEncontrado.Documento = tecnico.Documento;
                tecnicoEncontrado.PrimerNombre = tecnico.PrimerNombre;
                tecnicoEncontrado.SegundoNombre = tecnico.SegundoNombre;
                tecnicoEncontrado.PrimerApellido = tecnico.PrimerApellido;
                tecnicoEncontrado.SegundoApellido = tecnico.SegundoApellido;
                tecnicoEncontrado.FechaNacimiento = tecnico.FechaNacimiento;
                tecnicoEncontrado.telefono = tecnico.telefono;
                tecnicoEncontrado.Direccion = tecnico.Direccion;
                tecnicoEncontrado.NivelEstudios = tecnico.NivelEstudios;
                tecnicoEncontrado.Impresoras = tecnico.Impresoras;
                tecnicoEncontrado.ServiciosTecnicos = tecnico.ServiciosTecnicos;
                this._appContext.SaveChanges();
            }
            return tecnicoEncontrado;
        }
        public Tecnico getByDocument(int document)
        {
            var tecnicoEncontrado = this._appContext.Tecnicos.FromSqlRaw(
                @"SELECT Id, Documento, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, telefono, Direccion, NivelEstudios FROM dbo.Tecnico WHERE documento = {0}", document
                ).FirstOrDefault();
            return tecnicoEncontrado;
        }
        public Tecnico getByLogin(int document, string pass)
        {
            var tecnicoEncontrado = this._appContext.Tecnicos.FromSqlRaw(
                @"SELECT * FROM dbo.Tecnico WHERE Password = '" + pass + "' AND Documento = {0}", document
                ).FirstOrDefault();
            return tecnicoEncontrado;
        }
    }
}
