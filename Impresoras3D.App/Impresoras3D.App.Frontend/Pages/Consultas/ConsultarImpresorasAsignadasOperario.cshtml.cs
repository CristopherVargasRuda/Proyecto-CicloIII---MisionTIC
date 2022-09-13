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
        [BindProperty]
        public int idOperario { get; set; }
        public ConsultarImpresorasAsignadasOperarioModel()
        { }
        public ActionResult OnGet(int id)
        {
            idOperario = id;
            this.Impresoras = _repositorioImpresora.getImpresorasByOperario(id);
            return Page();
        }
    }
}
