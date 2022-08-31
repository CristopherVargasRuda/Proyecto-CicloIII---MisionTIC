using System;

using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{

    public interface IRepositorioSeguro
    {

        public Seguro AddSeguro(Seguro Seguro);

        public void DeleteSeguro (int idSeguro);

        public Seguro getSeguro (int idSeguro);

        public IEnumerable <Seguro> GetAllSeguro();

        public Seguro UpdateSeguro(Seguro Seguro);

    }


}