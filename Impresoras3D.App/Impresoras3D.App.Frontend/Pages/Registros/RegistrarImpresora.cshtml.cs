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
        private static IRepositorioComponente _repositorioComponente = new RepositorioComponente(new Impresoras3D.App.Persistencia.AppContext());
        private static IRepositorioImpresoraComponente _repositorioImpresoraComponente = new RepositorioImpresoraComponente(new Impresoras3D.App.Persistencia.AppContext());
        [BindProperty]
        public Impresora Impresora { get; set; }
        [BindProperty]
        public IEnumerable<Estado> Estados { get; set; }
        [BindProperty]
        public IEnumerable<Software> Softwares { get; set; }
        [BindProperty]
        public IEnumerable<Componente> Cabeceras { get; set; }
        [BindProperty]
        public IEnumerable<Componente> Extrusores { get; set; }
        [BindProperty]
        public IEnumerable<Componente> Camas { get; set; }
        [BindProperty]
        public IEnumerable<Componente> Fuentes { get; set; }
        [BindProperty]
        public Componente Cabecera { get; set; }
        [BindProperty]
        public Componente Extrusor { get; set; }
        [BindProperty]
        public Componente Cama { get; set; }
        [BindProperty]
        public Componente Fuente { get; set; }
        public RegistrarImpresoraModel()
        { }
        public ActionResult OnGet()
        {
            this.Estados = _repositorioEstado.GetImpresoraEstados();
            this.Softwares = _repositorioSoftware.GetAllSoftware();
            this.Cabeceras = _repositorioComponente.getCabezarComponentes();
            this.Fuentes = _repositorioComponente.getFuenteComponentes();
            this.Camas = _repositorioComponente.getCamaComponentes();
            this.Extrusores = _repositorioComponente.getExtrusorComponentes();
            return Page();
        }

        public ActionResult OnPost()
        {
            try
            {
                Impresora impresoraObtenida = _repositorioImpresora.AddImpresora(this.Impresora);
                ImpresoraComponente impresoraComponenteCabecera = new ImpresoraComponente();
                ImpresoraComponente impresoraComponenteCama = new ImpresoraComponente();
                ImpresoraComponente impresoraComponenteExtrusor = new ImpresoraComponente();
                ImpresoraComponente impresoraComponenteFuente = new ImpresoraComponente();
                impresoraComponenteCabecera.ImpresoraId = this.Impresora.Id;
                impresoraComponenteCama.ImpresoraId = this.Impresora.Id;
                impresoraComponenteExtrusor.ImpresoraId = this.Impresora.Id;
                impresoraComponenteFuente.ImpresoraId = this.Impresora.Id;
                impresoraComponenteCabecera.ComponenteId = Cabecera.Id;
                impresoraComponenteCabecera.EstadoId = 10;
                _repositorioImpresoraComponente.AddImpresoraComponente(impresoraComponenteCabecera);
                impresoraComponenteCama.ComponenteId = Cama.Id;
                impresoraComponenteCama.EstadoId = 16;
                _repositorioImpresoraComponente.AddImpresoraComponente(impresoraComponenteCama);
                impresoraComponenteExtrusor.ComponenteId = Extrusor.Id;
                impresoraComponenteExtrusor.EstadoId = 13;
                _repositorioImpresoraComponente.AddImpresoraComponente(impresoraComponenteExtrusor);
                impresoraComponenteFuente.ComponenteId = Fuente.Id;
                impresoraComponenteFuente.EstadoId = 1;
                _repositorioImpresoraComponente.AddImpresoraComponente(impresoraComponenteFuente);
                return RedirectToPage("../Index");
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
                Console.Out.WriteLine(Cabecera.Id);
                Console.Out.WriteLine(Cama.Id);
                Console.Out.WriteLine(Fuente.Id);
                Console.Out.WriteLine(Extrusor.Id);
                this.Estados = _repositorioEstado.GetImpresoraEstados();
                this.Softwares = _repositorioSoftware.GetAllSoftware();
                this.Cabeceras = _repositorioComponente.getCabezarComponentes();
                this.Fuentes = _repositorioComponente.getFuenteComponentes();
                this.Camas = _repositorioComponente.getCamaComponentes();
                this.Extrusores = _repositorioComponente.getExtrusorComponentes();
                return Page();
            }
        }
    }
}
