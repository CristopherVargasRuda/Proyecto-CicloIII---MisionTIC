using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Impresoras3D.App.Persistencia;
using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Frontend.Pages
{
    public class ConsultarImpresorasAsignadasTecnicoModel : PageModel
    {
        private static IRepositorioImpresora _repositorioImpresora = new RepositorioImpresora(new Impresoras3D.App.Persistencia.AppContext());
        [BindProperty]
        public IEnumerable<Impresora> Impresoras { get; set; }
        [BindProperty]
        public int idTecnico { get; set; }
        public ConsultarImpresorasAsignadasTecnicoModel()
        { }
        public ActionResult OnGet(int id)
        {
            idTecnico = id;
            this.Impresoras = _repositorioImpresora.getImpresorasByTecnico(id);
            return Page();
        }

        public ActionResult OnPost()
        {
            Console.Out.WriteLine(TempData["TipoUsuario"]);
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
