using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Impresoras3D.App.Dominio;
using Impresoras3D.App.Persistencia;

namespace Impresoras3D.App.Frontend.Pages
{
    public class RegistrarTecnicoModel : PageModel
    {
        private static IRepositorioTecnico _repositorioTecnico = new RepositorioTecnico(new Impresoras3D.App.Persistencia.AppContext());
        [BindProperty]
        public Tecnico Tecnico { get; set; }
        public RegistrarTecnicoModel()
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
                Tecnico tecnicoRegistrado = _repositorioTecnico.AddTecnico(this.Tecnico);
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
                Console.Out.WriteLine(Tecnico.Documento);
                Console.Out.WriteLine(Tecnico.telefono);
                Console.Out.WriteLine(Tecnico.FechaNacimiento);
                Console.Out.WriteLine(Tecnico.PrimerNombre);
                Console.Out.WriteLine(Tecnico.SegundoNombre);
                Console.Out.WriteLine(Tecnico.PrimerApellido);
                Console.Out.WriteLine(Tecnico.SegundoApellido);
                Console.Out.WriteLine(Tecnico.Direccion);
                Console.Out.WriteLine(Tecnico.NivelEstudios);
                return Page();
            }
        }

    }
}
