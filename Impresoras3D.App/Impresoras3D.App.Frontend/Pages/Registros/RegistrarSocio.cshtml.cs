using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Impresoras3D.App.Dominio;
using Impresoras3D.App.Persistencia;

namespace Impresoras3D.App.Frontend.Pages
{
    public class RegistrarSocioModel : PageModel
    {
        private static IRepositorioSocioEmpresa _repositorioSocioEmpresa = new RepositorioSocioEmpresa(new Impresoras3D.App.Persistencia.AppContext());
        [BindProperty]
        public SocioEmpresa SocioEmpresa { get; set; }
        public RegistrarSocioModel()
        { }
        public ActionResult OnGet()
        {
            return Page();
        }

        public ActionResult OnPost()
        {
            try
            {
                SocioEmpresa socioEmpresaRegistrado = _repositorioSocioEmpresa.AddSocioEmpresa(this.SocioEmpresa);
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
                Console.Out.WriteLine(SocioEmpresa.Documento);
                Console.Out.WriteLine(SocioEmpresa.telefono);
                Console.Out.WriteLine(SocioEmpresa.FechaNacimiento);
                Console.Out.WriteLine(SocioEmpresa.PrimerNombre);
                Console.Out.WriteLine(SocioEmpresa.SegundoNombre);
                Console.Out.WriteLine(SocioEmpresa.PrimerApellido);
                Console.Out.WriteLine(SocioEmpresa.SegundoApellido);
                return Page();
            }
        }
    }
}
