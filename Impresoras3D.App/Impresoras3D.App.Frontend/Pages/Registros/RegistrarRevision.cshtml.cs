using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Impresoras3D.App.Dominio;
using Impresoras3D.App.Persistencia;

namespace Impresoras3D.App.Frontend.Pages
{
    public class RegistrarRevisionModel : PageModel
    {
        private static IRepositorioImpresora _repositorioImpresora = new RepositorioImpresora(new Impresoras3D.App.Persistencia.AppContext());
        private static IRepositorioComponente _repositorioComponente = new RepositorioComponente(new Impresoras3D.App.Persistencia.AppContext());
        private static IRepositorioMantenimientoComponente _repositorioMantenimientoComponente = new RepositorioMantenimientoComponente(new Impresoras3D.App.Persistencia.AppContext());
        private static IRepositorioCambioComponente _repositorioCambioComponente = new RepositorioCambioComponente(new Impresoras3D.App.Persistencia.AppContext());
        private static IRepositorioServicioTecnico _repositorioServicioTecnico = new RepositorioServicioTecnico(new Impresoras3D.App.Persistencia.AppContext());
        private static IRepositorioSoftware _repositorioSoftware = new RepositorioSoftware(new Impresoras3D.App.Persistencia.AppContext());
        private static IRepositorioTecnico _repositorioTecnico = new RepositorioTecnico(new Impresoras3D.App.Persistencia.AppContext());
        private static IRepositorioOperario _repositorioOperario = new RepositorioOperario(new Impresoras3D.App.Persistencia.AppContext());
        private static IRepositorioEstado _repositorioEstado = new RepositorioEstado(new Impresoras3D.App.Persistencia.AppContext());
        [BindProperty]
        public Impresora Impresora { get; set; }
        [BindProperty]
        public ServicioTecnico ServicioTecnico { get; set; }
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
        public IEnumerable<Estado> Estados { get; set; }
        [BindProperty]
        public Tecnico Tecnico { get; set; }
        [BindProperty]
        public Operario Operario { get; set; }
        [BindProperty]
        public Componente CambioComponenteCabezal { get; set; }
        [BindProperty]
        public Componente CambioComponenteExtrusor { get; set; }
        [BindProperty]
        public Componente CambioComponenteCama { get; set; }
        [BindProperty]
        public Componente CambioComponenteFuente { get; set; } 
        [BindProperty]
        public Software Software { get; set; }  
        [BindProperty]     
        public bool seActualizaSoftware { get; set; }
        [BindProperty]
        public bool seHaceMantenimientoCabezal { get; set; }
        [BindProperty]
        public bool seHaceMantenimientoExtrusor { get; set; }
        [BindProperty]
        public bool seHaceMantenimientoCama { get; set; }
        [BindProperty]
        public bool seHaceMantenimientoFuente { get; set; }
        [BindProperty]
        public bool seHaceCambioCabezal { get; set; }
        [BindProperty]
        public bool seHaceCambioExtrusor { get; set; }
        [BindProperty]
        public bool seHaceCambioCama { get; set; }
        [BindProperty]
        public bool seHaceCambioFuente { get; set; }
        public ActionResult OnGet(int id)
        {
            this.Estados = _repositorioEstado.GetImpresoraEstados();
            this.Softwares = _repositorioSoftware.GetAllSoftware();
            this.Cabeceras = _repositorioComponente.getCabezarComponentes();
            this.Fuentes = _repositorioComponente.getFuenteComponentes();
            this.Camas = _repositorioComponente.getCamaComponentes();
            this.Extrusores = _repositorioComponente.getExtrusorComponentes();
            this.Impresora = _repositorioImpresora.getImpresora(id);
            this.Tecnico = _repositorioTecnico.getTecnico(Impresora.TecnicoId);
            this.Operario = _repositorioOperario.getOperario(Impresora.OperarioId);
            return Page();
        }
        public ActionResult OnPost() {

            
            return Page();
        }
    }
}
