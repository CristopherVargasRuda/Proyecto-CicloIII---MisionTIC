using System;

using Impresoras3D.App.Dominio;

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
            var componenteEncontrado= this._appContext.Componentes.FirstOrDefault(
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
    }
}
