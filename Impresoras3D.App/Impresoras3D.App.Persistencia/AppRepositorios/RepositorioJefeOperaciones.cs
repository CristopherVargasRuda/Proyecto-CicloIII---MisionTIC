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

        public void DeleteJefeOperaciones(int documentoJefeOperaciones)
        {
            var jefeOperaciones = this._appContext.JefeOperaciones.FirstOrDefault(
                j => j.Documento == documentoJefeOperaciones
            );

            if (jefeOperaciones == null)
            {
                return;
            }

            this._appContext.JefeOperaciones.Remove(jefeOperaciones);

            this._appContext.SaveChanges();
        }

        public JefeOperaciones getJefeOperaciones(int documentoJefeOperaciones)
        {
            var jefeOperaciones = this._appContext.JefeOperaciones.FirstOrDefault ( j => j.Documento == documentoJefeOperaciones);

            return jefeOperaciones;
        }

        public IEnumerable <JefeOperaciones> GetAllJefeOperaciones()
        {
            return this._appContext.JefeOperaciones;
        }



        public JefeOperaciones UpdateJefeOperaciones(JefeOperaciones jefeOperaciones)
        {


            var jefeOperacionesEncontrado = this._appContext.JefeOperaciones.FirstOrDefault( a => a.Documento == jefeOperaciones.Documento);


            if( jefeOperacionesEncontrado !=null)
            {
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
