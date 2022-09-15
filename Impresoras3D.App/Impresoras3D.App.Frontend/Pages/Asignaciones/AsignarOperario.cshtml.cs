using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Impresoras3D.App.Dominio;
using Impresoras3D.App.Persistencia;

namespace Impresoras3D.App.Frontend.Pages
{
    public class AsignarOperarioModel : PageModel
    {
        private static IRepositorioOperario _repositorioOperario = new RepositorioOperario(new Impresoras3D.App.Persistencia.AppContext());
        private static IRepositorioImpresora _repositorioImpresora = new RepositorioImpresora(new Impresoras3D.App.Persistencia.AppContext());
        [BindProperty]
        public IEnumerable<Impresora> Impresoras { get; set; }
        [BindProperty]
        public IEnumerable<Operario> Operarios { get; set; }
        [BindProperty]
        public Operario Operario { get; set; }
        [BindProperty]
        public Impresora Impresora { get; set; }
        public AsignarOperarioModel()
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
            Impresoras = _repositorioImpresora.GetAllImpresora();
            Operarios = _repositorioOperario.GetAllOperario();
            return Page();
        }
        public ActionResult OnPost()
        {
            try
            {
                this.Impresora = _repositorioImpresora.getImpresora(this.Impresora.Id);
                Impresora.OperarioId = Operario.Id;
                Impresora impresoraActualizada = _repositorioImpresora.UpdateImpresora(Impresora);
                return RedirectToPage("../Login/LogueoAuxiliar");
            }
            catch (System.Exception e)
            {
                ViewData["Error"] = e.Message;
                Console.Out.WriteLine(Impresora.Id);
                Console.Out.WriteLine(Operario.Id);
                return Page();
            }
        }
    }
}
