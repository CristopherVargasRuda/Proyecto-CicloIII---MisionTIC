using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Impresoras3D.App.Dominio;
using Impresoras3D.App.Persistencia;

namespace Impresoras3D.App.Frontend.Pages
{
    public class ConsultarDetallesRevisionModel : PageModel
    {
        private static IRepositorioComponente _repositorioComponente = new RepositorioComponente(new Impresoras3D.App.Persistencia.AppContext());
        // private static IRepositorioMantenimientoComponente _repositorioMantenimientoComponente = new RepositorioMantenimientoComponente(new Impresoras3D.App.Persistencia.AppContext());
        // private static IRepositorioCambioComponente _repositorioCambioComponente = new RepositorioCambioComponente(new Impresoras3D.App.Persistencia.AppContext());

        [BindProperty]
        public IEnumerable<Componente> ComponentesMantenimientos { get; set; }
        [BindProperty]
        public IEnumerable<Componente> ComponentesCambios { get; set; }
        public ConsultarDetallesRevisionModel()
        { }
        public ActionResult OnGet(int id)
        {
            this.ComponentesMantenimientos = _repositorioComponente.getComponentesMantenimientoByServicioId(id);
            this.ComponentesCambios = _repositorioComponente.getComponentesCambioByServicioId(id);
            return Page();
        }
    }
}
