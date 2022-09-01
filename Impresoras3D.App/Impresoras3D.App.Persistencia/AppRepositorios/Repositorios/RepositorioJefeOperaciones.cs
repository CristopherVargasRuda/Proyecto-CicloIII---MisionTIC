using System;

using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{
    public class RepositorioJefeOperaciones : IRepositorioJefeOperaciones
    {
        private readonly AppContext _appContext;

        public RepositorioJefeOperaciones(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public JefeOperaciones AddJefeOperaciones(JefeOperaciones jefeOperaciones)
        {
            var jefeOperacionesAdicionado = this._appContext.JefeOperaciones.Add(jefeOperaciones);

            this._appContext.SaveChanges();

            return jefeOperacionesAdicionado.Entity;
        }

        public void DeleteJefeOperaciones(int idJefeOperaciones)
        {
            var jefeOperaciones = this._appContext.JefeOperaciones.FirstOrDefault(
                j => j.Id == idJefeOperaciones
            );

            if (jefeOperaciones == null)
            {
                return;
            }

            this._appContext.JefeOperaciones.Remove(jefeOperaciones);

            this._appContext.SaveChanges();
        }

        public JefeOperaciones getJefeOperaciones(int idJefeOperaciones)
        {
            var jefeOperaciones = this._appContext.JefeOperaciones.FirstOrDefault(
                j => j.Id == idJefeOperaciones
            );

            return jefeOperaciones;
        }

        public IEnumerable<JefeOperaciones> GetAllJefeOperaciones()
        {
            return this._appContext.JefeOperaciones;
        }

        public JefeOperaciones UpdateJefeOperaciones(JefeOperaciones jefeOperaciones)
        {
            var jefeOperacionesEncontrado = this._appContext.JefeOperaciones.FirstOrDefault(
                a => a.Id == jefeOperaciones.Id
            );

            if (jefeOperacionesEncontrado != null)
            {
                jefeOperacionesEncontrado.Documento = jefeOperaciones.Documento;

                jefeOperacionesEncontrado.PrimerNombre = jefeOperaciones.PrimerNombre;

                jefeOperacionesEncontrado.SegundoNombre = jefeOperaciones.SegundoNombre;

                jefeOperacionesEncontrado.PrimerApellido = jefeOperaciones.PrimerApellido;

                jefeOperacionesEncontrado.SegundoApellido = jefeOperaciones.SegundoApellido;

                jefeOperacionesEncontrado.FechaNacimiento = jefeOperaciones.FechaNacimiento;

                jefeOperacionesEncontrado.telefono = jefeOperaciones.telefono;

                this._appContext.SaveChanges();
            }

            return jefeOperacionesEncontrado;
        }
    }
}
