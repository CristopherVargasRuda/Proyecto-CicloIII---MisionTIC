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
        public CompraSeguro CompraSeguro { get; set; }

        public void OnGet(int id)
        {
            if (
                TempData.ContainsKey("Id")
                && TempData.ContainsKey("Nombre")
                && TempData.ContainsKey("TipoUsuario")
            )
            {
                TempData.Keep("Id");
                TempData.Keep("Nombre");
                TempData.Keep("TipoUsuario");
            }
            IEnumerable<CompraSeguro> ComprasSeguros = _repositorioCompraSeguro.getCompraSeguroByImpresoraId(id);
            this.CompraSeguro = ComprasSeguros.Last();
        }
    }
}
