using System;

using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{

    public interface IRepositorioSeguroYTipoCubrimiento
    {

        public SeguroYTipoCubrimiento AddSeguroYTipoCubrimiento(SeguroYTipoCubrimiento SeguroYTipoCubrimiento);

        public void DeleteSeguroYTipoCubrimiento (int idSeguro, int idTipoCubrimiento);

        public SeguroYTipoCubrimiento getSeguroYTipoCubrimiento (int idSeguro, int idTipoCubrimiento);

        public IEnumerable <SeguroYTipoCubrimiento> GetAllSeguroYTipoCubrimiento();

    }


}