using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Impresoras3D.App.Dominio;
using Impresoras3D.App.Persistencia;

namespace Impresoras3D.App.Frontend.Pages
{
    public class ConsultarImpresorasModel : PageModel
    {
        private static IRepositorioImpresora _repositorioImpresora = new RepositorioImpresora(
            new Impresoras3D.App.Persistencia.AppContext()
        );

        private static IRepositorioSoftware _repositorioSoftware = new RepositorioSoftware(
            new Impresoras3D.App.Persistencia.AppContext()
        );

        private static IRepositorioEstado _repositorioEstado = new RepositorioEstado(
            new Impresoras3D.App.Persistencia.AppContext()
        );

        private static IRepositorioComponente _repositorioComponente = new RepositorioComponente(
            new Impresoras3D.App.Persistencia.AppContext()
        );

        [BindProperty]
        public Impresora Impresora { get; set; }
        [BindProperty]
        public Impresora impresoraObtenida { get; set; }
        [BindProperty]
        public Software softwareObtenido { get; set; }
        [BindProperty]
        public Estado estadoSoftwareObtenido { get; set; }
        [BindProperty]
        public Estado estadoImpresoraObtenida { get; set; }
        [BindProperty]
        public List<Componente> componentesObtenidos { get; set; }

        public ConsultarImpresorasModel() { }

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
            try
            {
                this.impresoraObtenida = _repositorioImpresora.getByPlaca(
                    Impresora.PlacaInventario
                );

                this.softwareObtenido = _repositorioSoftware.getSoftware(
                    this.impresoraObtenida.SoftwareId
                );

                this.estadoImpresoraObtenida = _repositorioEstado.getEstado(
                    this.impresoraObtenida.EstadoID
                );

                this.estadoSoftwareObtenido = _repositorioEstado.getEstado(
                    this.softwareObtenido.EstadoId
                );

                IEnumerable<Componente> cabezales = _repositorioComponente.getCabezarComponentesByImpresoraID(impresoraObtenida.Id);
                IEnumerable<Componente> extrusores = _repositorioComponente.getExtrusorComponentesByImpresoraID(impresoraObtenida.Id);
                IEnumerable<Componente> camas = _repositorioComponente.getCamaComponentesByImpresoraID(impresoraObtenida.Id);
                IEnumerable<Componente> fuentes = _repositorioComponente.getFuenteComponentesByImpresoraID(impresoraObtenida.Id);

                Componente cabezal = cabezales.Last();
                Componente extrusor = extrusores.Last();
                Componente cama = camas.Last();
                Componente fuente = fuentes.Last();

                this.componentesObtenidos = new List<Componente>();
                this.componentesObtenidos.Add(cabezal);
                this.componentesObtenidos.Add(extrusor);
                this.componentesObtenidos.Add(cama);
                this.componentesObtenidos.Add(fuente);

                return Page();
            }
            catch (System.Exception e)
            {
                @ViewData["Error"] = e.Message;
            }

            @ViewData["Error"] = "Impresora no encontrada";

            return Page();
        }
    }
}
