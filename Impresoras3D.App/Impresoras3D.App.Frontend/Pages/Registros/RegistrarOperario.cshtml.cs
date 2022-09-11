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
            return Page();
        }

        public ActionResult OnPost()
        {
            try
            {
                Operario operarioRegistrado = _repositorioOperario.AddOperario(this.Operario);
                return RedirectToPage("../Index");
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
