using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Impresoras3D.App.Dominio;
using Impresoras3D.App.Persistencia;

namespace Impresoras3D.App.Frontend.Pages
{
    public class ConsultarSeguroImpresoraModel : PageModel
    {
        private static IRepositorioCompraSeguro _repositorioCompraSeguro =
            new RepositorioCompraSeguro(new Impresoras3D.App.Persistencia.AppContext());

        private static IRepositorioSeguro _repositorioSeguro = new RepositorioSeguro(
            new Impresoras3D.App.Persistencia.AppContext()
        );

        [BindProperty]
        public Seguro seguro { get; set; }

        [BindProperty]
        public CompraSeguro CompraSeguros { get; set; }

        public void OnGet(int ImpresoraId)
        {
            CompraSeguros = _repositorioCompraSeguro.getCompraSeguroByImpresoraId(ImpresoraId);
        }
    }
}
