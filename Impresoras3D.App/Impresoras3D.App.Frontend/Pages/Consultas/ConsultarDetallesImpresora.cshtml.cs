using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Impresoras3D.App.Dominio;
using Impresoras3D.App.Persistencia;

namespace Impresoras3D.App.Frontend.Pages
{
    public class ConsultarDetallesImpresoraModel : PageModel
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
        public Impresora impresoraObtenida { get; set; }
        [BindProperty]
        public Software softwareObtenido { get; set; }
        [BindProperty]
        public Estado estadoSoftwareObtenido { get; set; }
        [BindProperty]
        public Estado estadoImpresoraObtenida { get; set; }
        [BindProperty]
        public List<Componente> componentesObtenidos { get; set; }
        public ConsultarDetallesImpresoraModel() { }

        public ActionResult OnGet(int id)
        {
            try
            {
                this.impresoraObtenida = _repositorioImpresora.getImpresora(id);
                this.softwareObtenido = _repositorioSoftware.getSoftware(
                    this.impresoraObtenida.SoftwareId
                );

                this.estadoImpresoraObtenida = _repositorioEstado.getEstado(
                    this.impresoraObtenida.EstadoID
                );
                
                this.estadoSoftwareObtenido = _repositorioEstado.getEstado(
                    this.softwareObtenido.EstadoId
                );

                IEnumerable<Componente> cabezales = _repositorioComponente.getCabezarComponentesByImpresoraID(id);
                IEnumerable<Componente> extrusores = _repositorioComponente.getExtrusorComponentesByImpresoraID(id);
                IEnumerable<Componente> camas = _repositorioComponente.getCamaComponentesByImpresoraID(id);
                IEnumerable<Componente> fuentes = _repositorioComponente.getFuenteComponentesByImpresoraID(id);

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
            return Page();
        }
    }
}
