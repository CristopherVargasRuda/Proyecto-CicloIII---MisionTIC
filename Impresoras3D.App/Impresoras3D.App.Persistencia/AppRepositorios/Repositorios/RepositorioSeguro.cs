using System;
using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{
    public class RepositorioSeguro : IRepositorioSeguro
    {
        private readonly AppContext _appContext;
        public RepositorioSeguro(AppContext appContext)
        {
            this._appContext = appContext;
        }
        public Seguro AddSeguro(Seguro seguro)
        {
            var seguroAdicionado = this._appContext.Seguros.Add(seguro);

            this._appContext.SaveChanges();

            return seguroAdicionado.Entity;
        }
        public void DeleteSeguro(int idSeguro)
        {
            var seguro = this._appContext.Seguros.FirstOrDefault(s => s.Id == idSeguro);
            if (seguro == null)
            {
                return;
            }
            this._appContext.Seguros.Remove(seguro);
            this._appContext.SaveChanges();
        }

        public Seguro getSeguro(int idSeguro)
        {
            var seguro = this._appContext.Seguros.FirstOrDefault(s => s.Id == idSeguro);
            return seguro;
        }
        public IEnumerable<Seguro> GetAllSeguro()
        {
            return this._appContext.Seguros;
        }
        public Seguro UpdateSeguro(Seguro seguro)
        {
            var seguroEncontrado = this._appContext.Seguros.FirstOrDefault(s => s.Id == seguro.Id);
            if (seguroEncontrado != null)
            {
                seguroEncontrado.CompraSeguros = seguro.CompraSeguros;
                seguroEncontrado.SegurosYTipoCubrimiento = seguro.SegurosYTipoCubrimiento;
                this._appContext.SaveChanges();
            }
            return seguroEncontrado;
        }
    }
}
