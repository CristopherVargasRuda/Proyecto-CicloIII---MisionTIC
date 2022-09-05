using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Impresoras3D.App.Dominio;
using Impresoras3D.App.Persistencia;

namespace Impresoras3D.App.Frontend.Pages
{
    public class RegistrarImpresoraModel : PageModel
    {

        private static IRepositorioImpresora _repositorioImpresora = new RepositorioImpresora(new Impresoras3D.App.Persistencia.AppContext());
        private static IRepositorioEstado _repositorioEstado = new RepositorioEstado(new Impresoras3D.App.Persistencia.AppContext());
        private static IRepositorioSoftware _repositorioSoftware = new RepositorioSoftware(new Impresoras3D.App.Persistencia.AppContext());

        [BindProperty] //Asocia al usuario
        public Impresora Impresora { get; set; }
        [BindProperty] 
        public IEnumerable<Estado> Estados { get; set; }
        [BindProperty] 
        public IEnumerable<Software> Softwares { get; set; }
        public RegistrarImpresoraModel()
        { }

        public ActionResult OnGet()
        {
            this.Estados = _repositorioEstado.GetImpresoraEstados();
            this.Softwares = _repositorioSoftware.GetAllSoftware();
            return Page();
        }

        public ActionResult OnPost()
        {
            try
            {
                Impresora impresoraObtenida = _repositorioImpresora.AddImpresora(this.Impresora);
                this.Estados = _repositorioEstado.GetImpresoraEstados();
                this.Softwares = _repositorioSoftware.GetAllSoftware();
                return Page();
            }
            catch (System.Exception e)
            {
                ViewData["Error"] = e.Message;
                Console.Out.WriteLine(Impresora.PlacaInventario);
                Console.Out.WriteLine(Impresora.Tipo);
                Console.Out.WriteLine(Impresora.Marca);
                Console.Out.WriteLine(Impresora.Modelo);
                Console.Out.WriteLine(Impresora.VelocidaImpresion);
                Console.Out.WriteLine(Impresora.VolumenImpresionX);
                Console.Out.WriteLine(Impresora.VolumenImpresionY);
                Console.Out.WriteLine(Impresora.VolumenImpresionZ);
                Console.Out.WriteLine(Impresora.PaisOrigen);
                Console.Out.WriteLine(Impresora.EstadoID);
                Console.Out.WriteLine(Impresora.SoftwareId);
                this.Estados = _repositorioEstado.GetImpresoraEstados();
                this.Softwares = _repositorioSoftware.GetAllSoftware();
                return Page();
            }
        }
    }
}
