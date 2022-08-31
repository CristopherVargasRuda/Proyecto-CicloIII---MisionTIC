using System;

using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{
    public class RepositorioSeguroYTipoCubrimiento : IRepositorioSeguroYTipoCubrimiento
    {
        private readonly AppContext _appContext;

        public RepositorioSeguroYTipoCubrimiento(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public SeguroYTipoCubrimiento AddSeguroYTipoCubrimiento(SeguroYTipoCubrimiento seguroYTipoCubrimiento)
        {
            var seguroYTipoCubrimientoAdicionado = this._appContext.SeguroYTipoCubrimientos.Add(seguroYTipoCubrimiento);

            this._appContext.SaveChanges();

            return seguroYTipoCubrimientoAdicionado.Entity;
        }

        public void DeleteSeguroYTipoCubrimiento(int idSeguro, int idTipoCubrimiento)
        {
            var seguroYTipoCubrimiento = this._appContext.SeguroYTipoCubrimientos.FirstOrDefault(s => s.SeguroId == idSeguro && s.TipoCubrimientoId == idTipoCubrimiento);

            if (seguroYTipoCubrimiento == null)
            {
                return;
            }

            this._appContext.SeguroYTipoCubrimientos.Remove(seguroYTipoCubrimiento);

            this._appContext.SaveChanges();
        }

        public SeguroYTipoCubrimiento getSeguroYTipoCubrimiento(int idSeguro, int idTipoCubrimiento)
        {
            var seguroYTipoCubrimiento = this._appContext.SeguroYTipoCubrimientos.FirstOrDefault ( s => s.SeguroId == idSeguro && s.TipoCubrimientoId == idTipoCubrimiento);

            return seguroYTipoCubrimiento;
        }

        public IEnumerable <SeguroYTipoCubrimiento> GetAllSeguroYTipoCubrimiento()
        {
            return this._appContext.SeguroYTipoCubrimientos;
        }



    }
}
