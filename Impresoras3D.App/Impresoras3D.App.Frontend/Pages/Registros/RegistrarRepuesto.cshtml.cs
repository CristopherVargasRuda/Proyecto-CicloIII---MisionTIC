using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Impresoras3D.App.Dominio;
using Impresoras3D.App.Persistencia;

namespace Impresoras3D.App.Frontend.Pages
{
    public class RegistrarRepuestoModel : PageModel
    {
        private static IRepositorioComponente _repositorioComponente = new RepositorioComponente(new Impresoras3D.App.Persistencia.AppContext());
        [BindProperty]
        public String TipoRepuesto { get; set; }
        [BindProperty]
        public Componente Componente { get; set; }
        public RegistrarRepuestoModel()
        { }
        public ActionResult OnGet()
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
            return Page();
        }

        public ActionResult OnPost()
        {
            try
            {
                Componente.Nombre = TipoRepuesto + " " + Componente.Nombre;
                Componente componenteNuevo = _repositorioComponente.AddComponente(this.Componente);
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
                ViewData["Error"] = e.Message;
                Console.Out.WriteLine(TipoRepuesto + " " + Componente.Nombre);
                Console.Out.WriteLine(Componente.Descripcion);
                return Page();
            }
        }
    }
}
