using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Impresoras3D.App.Dominio;
using Impresoras3D.App.Persistencia;

namespace Impresoras3D.App.Frontend.Pages
{
    public class ConsultarDetallesRevisionModel : PageModel
    {
        private static IRepositorioComponente _repositorioComponente = new RepositorioComponente(new Impresoras3D.App.Persistencia.AppContext());

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
        public ActionResult OnPost()
        {
            try
            {
                switch (TempData["TipoUsuario"])
                {
                    case "Tecnico":
                        return RedirectToPage("../Login/LogueoTecnico");
                        break;
                    case "Operario":
                        return RedirectToPage("../Login/LogueoOperario");
                        break;
                    case "SocioEmpresa":
                        return RedirectToPage("../Login/LogueoSocioEmpresa");
                        break;
                    case "Auxiliar":
                        return RedirectToPage("../Login/LogueoAuxiliar");
                        break;
                    case "JefeOperaciones":
                        return RedirectToPage("../Login/LogueoJefeOperaciones");
                        break;
                    default:
                        return RedirectToPage("../Index");
                        break;
                }
            }
            catch (System.Exception e)
            {
                return Page();
            }
        }
    }
}
