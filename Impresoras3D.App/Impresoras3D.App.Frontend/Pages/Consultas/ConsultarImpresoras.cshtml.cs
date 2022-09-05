using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Impresoras3D.App.Dominio;
using Impresoras3D.App.Persistencia;

namespace Impresoras3D.App.Frontend.Pages
{
    public class ConsultarImpresorasModel : PageModel
    {
        private static IRepositorioImpresora _repositorioImpresora = new RepositorioImpresora(
            new Impresoras3D.App.Persistencia.AppContext()
        );

        [BindProperty]
        public Impresora Impresora { get; set; }

        public ConsultarImpresorasModel() { }

        public ActionResult OnGet()
        {
            this.Impresora = null;
            return Page();
        }

        public ActionResult OnPost() {
            Impresora impresoraObtenida = _repositorioImpresora.getImpresora(Int32.Parse(Impresora.PlacaInventario));
            return Page();
         }
    }
}
