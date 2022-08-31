using System;

using Impresoras3D.App.Dominio;

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

        public void DeleteTecnico(int documentoTecnico)
        {
            var tecnico = this._appContext.Tecnicos.FirstOrDefault(
                t => t.Documento == documentoTecnico
            );

            if (tecnico == null)
            {
                return;
            }

            this._appContext.Tecnicos.Remove(tecnico);

            this._appContext.SaveChanges();
        }

        public Tecnico getTecnico(int documentoTecnico)
        {
            var tecnico = this._appContext.Tecnicos.FirstOrDefault(
                t => t.Documento == documentoTecnico
            );

            return tecnico;
        }

        public IEnumerable<Tecnico> GetAllTecnico()
        {
            return this._appContext.Tecnicos;
        }

        public Tecnico UpdateTecnico(Tecnico tecnico)
        {
            var tecnicoEncontrado = this._appContext.Tecnicos.FirstOrDefault(
                t => t.Documento == tecnico.Documento
            );

            if (tecnicoEncontrado != null)
            {
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
    }
}
