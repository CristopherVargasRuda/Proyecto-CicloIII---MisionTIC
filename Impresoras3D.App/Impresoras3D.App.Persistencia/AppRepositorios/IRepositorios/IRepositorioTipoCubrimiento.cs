using System;
using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{
    public interface IRepositorioTipoCubrimiento
    {
        public TipoCubrimiento AddTipoCubrimiento(TipoCubrimiento TipoCubrimiento);
        public void DeleteTipoCubrimiento(int idTipoCubrimiento);
        public TipoCubrimiento getTipoCubrimiento(int idTipoCubrimiento);
        public IEnumerable<TipoCubrimiento> GetAllTipoCubrimiento();
        public TipoCubrimiento UpdateTipoCubrimiento(TipoCubrimiento TipoCubrimiento);
    }
}