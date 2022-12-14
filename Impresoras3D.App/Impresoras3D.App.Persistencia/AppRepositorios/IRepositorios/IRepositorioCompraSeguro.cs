using System;
using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{

    public interface IRepositorioCompraSeguro
    {
        public CompraSeguro AddCompraSeguro(CompraSeguro CompraSeguro);
        public void DeleteCompraSeguro(int idCompraSeguro);
        public CompraSeguro getCompraSeguro(int idCompraSeguro);
        public IEnumerable<CompraSeguro> GetAllCompraSeguro();
        public CompraSeguro UpdateCompraSeguro(CompraSeguro CompraSeguro);
        public IEnumerable<CompraSeguro> getCompraSeguroByImpresoraId(int ImpresoraId);
    }
}