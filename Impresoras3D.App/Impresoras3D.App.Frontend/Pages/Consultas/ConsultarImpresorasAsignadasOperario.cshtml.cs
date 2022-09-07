using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Impresoras3D.App.Persistencia;
using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Frontend.Pages
{
    public class ConsultarImpresorasAsignadasOperarioModel : PageModel
    {
        private static IRepositorioImpresora _repositorioImpresora = new RepositorioImpresora(new Impresoras3D.App.Persistencia.AppContext());
        [BindProperty]
        public IEnumerable<Impresora> Impresoras { get; set; }
        public ConsultarImpresorasAsignadasOperarioModel()
        { }
        public ActionResult OnGet()
        {
            this.Impresoras = _repositorioImpresora.getImpresorasByOperario(3);
            return Page();
        }
    }
}
