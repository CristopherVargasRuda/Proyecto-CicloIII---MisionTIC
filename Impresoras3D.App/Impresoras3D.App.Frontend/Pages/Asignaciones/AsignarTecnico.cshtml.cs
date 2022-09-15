using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Impresoras3D.App.Dominio;
using Impresoras3D.App.Persistencia;

namespace Impresoras3D.App.Frontend.Pages
{
    public class AsignarTecnicoModel : PageModel
    {
        private static IRepositorioTecnico _repositorioTecnico = new RepositorioTecnico(new Impresoras3D.App.Persistencia.AppContext());
        private static IRepositorioImpresora _repositorioImpresora = new RepositorioImpresora(new Impresoras3D.App.Persistencia.AppContext());
        [BindProperty]
        public IEnumerable<Impresora> Impresoras { get; set; }
        [BindProperty]
        public IEnumerable<Tecnico> Tecnicos { get; set; }
        [BindProperty]
        public Tecnico Tecnico { get; set; }
        [BindProperty]
        public Impresora Impresora { get; set; }
        public AsignarTecnicoModel()
        { }
        public ActionResult OnGet()
        {
            Impresoras = _repositorioImpresora.GetAllImpresora();
            Tecnicos = _repositorioTecnico.GetAllTecnico();
            return Page();
        }
        public ActionResult OnPost()
        {
            try
            {
                this.Impresora = _repositorioImpresora.getImpresora(this.Impresora.Id);
                Impresora.TecnicoId = Tecnico.Id;
                Impresora impresoraActualizada = _repositorioImpresora.UpdateImpresora(Impresora);
                return RedirectToPage("../Login/LogueoAuxiliar");
            }
            catch (System.Exception e)
            {
                ViewData["Error"] = e.Message;
                Console.Out.WriteLine(Impresora.Id);
                Console.Out.WriteLine(Tecnico.Id);
                return Page();
            }
        }
    }
}
