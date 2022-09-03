using System;

using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{
    public class RepositorioCambioComponente : IRepositorioCambioComponente
    {
        private readonly AppContext _appContext;

        public RepositorioCambioComponente(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public CambioComponente AddCambioComponente(CambioComponente cambioComponente)
        {
            var cambioComponenteAdicionado = this._appContext.CambioComponentes.Add(
                cambioComponente
            );

            this._appContext.SaveChanges();

            return cambioComponenteAdicionado.Entity;
        }

        public void DeleteCambioComponente(int idServicioTecnico, int idImpresoraComponente)
        {
            var cambioComponente = this._appContext.CambioComponentes.FirstOrDefault(
                c =>
                    c.ServicioTecnicoId == idServicioTecnico
                    && c.ImpresoraComponenteId == idImpresoraComponente
            );

            if (cambioComponente == null)
            {
                return;
            }

            this._appContext.CambioComponentes.Remove(cambioComponente);

            this._appContext.SaveChanges();
        }

        public CambioComponente getCambioComponente(
            int idServicioTecnico,
            int idImpresoraComponente
        )
        {
            var cambioComponente = this._appContext.CambioComponentes.FirstOrDefault(
                c =>
                    c.ServicioTecnicoId == idServicioTecnico
                    && c.ImpresoraComponenteId == idImpresoraComponente
            );

            return cambioComponente;
        }

        public IEnumerable<CambioComponente> GetAllCambioComponente()
        {
            return this._appContext.CambioComponentes;
        }
    }
}
