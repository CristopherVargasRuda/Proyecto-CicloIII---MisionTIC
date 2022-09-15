using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Impresoras3D.App.Dominio;
using Impresoras3D.App.Persistencia;

namespace Impresoras3D.App.Frontend.Pages
{
    public class RegistrarOperarioModel : PageModel
    {
        private static IRepositorioOperario _repositorioOperario = new RepositorioOperario(new Impresoras3D.App.Persistencia.AppContext());
        [BindProperty]
        public Operario Operario { get; set; }
        public RegistrarOperarioModel()
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
                Operario operarioRegistrado = _repositorioOperario.AddOperario(this.Operario);
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
                Console.Out.WriteLine(Operario.Documento);
                Console.Out.WriteLine(Operario.telefono);
                Console.Out.WriteLine(Operario.FechaNacimiento);
                Console.Out.WriteLine(Operario.PrimerNombre);
                Console.Out.WriteLine(Operario.SegundoNombre);
                Console.Out.WriteLine(Operario.PrimerApellido);
                Console.Out.WriteLine(Operario.SegundoApellido);
                return Page();
            }
        }
    }
}
