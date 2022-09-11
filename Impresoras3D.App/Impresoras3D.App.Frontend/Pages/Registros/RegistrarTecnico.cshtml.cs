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
            return Page();
        }

        public ActionResult OnPost()
        {
            try
            {
                Tecnico tecnicoRegistrado = _repositorioTecnico.AddTecnico(this.Tecnico);
                return RedirectToPage("../Index");
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
