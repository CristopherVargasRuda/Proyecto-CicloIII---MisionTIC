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
        private static IRepositorioImpresoraComponente _repositorioImpresoraComponente = new RepositorioImpresoraComponente(new Impresoras3D.App.Persistencia.AppContext());
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
        public ActionResult OnPost()
        {
            Impresora impresoraActualizar = _repositorioImpresora.getImpresora(ServicioTecnico.ImpresoraId);
            if (seActualizaSoftware)
            {
                Console.Out.WriteLine(Software.Id);
                ServicioTecnico.SoftwareId = Software.Id;
                impresoraActualizar.SoftwareId = Software.Id;
            }
            _repositorioServicioTecnico.AddServicioTecnico(ServicioTecnico);
            if (seHaceMantenimientoCabezal)
            {
                IEnumerable<ImpresoraComponente> impCom = _repositorioImpresoraComponente.GetImpresoraComponenteByImpresoraIdTipoCabezal(ServicioTecnico.ImpresoraId);
                ImpresoraComponente impresoraComponente = impCom.Last();
                MantenimientoComponente mantenimientoComponenteNuevo = new MantenimientoComponente();
                mantenimientoComponenteNuevo.ServicioTecnicoId = ServicioTecnico.Id;
                mantenimientoComponenteNuevo.ImpresoraComponenteId = impresoraComponente.Id;
                _repositorioMantenimientoComponente.AddMantenimientoComponente(mantenimientoComponenteNuevo);
            }
            if (seHaceMantenimientoExtrusor)
            {
                IEnumerable<ImpresoraComponente> impCom = _repositorioImpresoraComponente.GetImpresoraComponenteByImpresoraIdTipoExtrusor(ServicioTecnico.ImpresoraId);
                ImpresoraComponente impresoraComponente = impCom.Last();
                MantenimientoComponente mantenimientoComponenteNuevo = new MantenimientoComponente();
                mantenimientoComponenteNuevo.ServicioTecnicoId = ServicioTecnico.Id;
                mantenimientoComponenteNuevo.ImpresoraComponenteId = impresoraComponente.Id;
                _repositorioMantenimientoComponente.AddMantenimientoComponente(mantenimientoComponenteNuevo);
            }
            if (seHaceMantenimientoCama)
            {
                IEnumerable<ImpresoraComponente> impCom = _repositorioImpresoraComponente.GetImpresoraComponenteByImpresoraIdTipoCama(ServicioTecnico.ImpresoraId);
                ImpresoraComponente impresoraComponente = impCom.Last();
                MantenimientoComponente mantenimientoComponenteNuevo = new MantenimientoComponente();
                mantenimientoComponenteNuevo.ServicioTecnicoId = ServicioTecnico.Id;
                mantenimientoComponenteNuevo.ImpresoraComponenteId = impresoraComponente.Id;
                _repositorioMantenimientoComponente.AddMantenimientoComponente(mantenimientoComponenteNuevo);
            }
            if (seHaceMantenimientoFuente)
            {
                IEnumerable<ImpresoraComponente> impCom = _repositorioImpresoraComponente.GetImpresoraComponenteByImpresoraIdTipoFuente(ServicioTecnico.ImpresoraId);
                ImpresoraComponente impresoraComponente = impCom.Last();
                MantenimientoComponente mantenimientoComponenteNuevo = new MantenimientoComponente();
                mantenimientoComponenteNuevo.ServicioTecnicoId = ServicioTecnico.Id;
                mantenimientoComponenteNuevo.ImpresoraComponenteId = impresoraComponente.Id;
                _repositorioMantenimientoComponente.AddMantenimientoComponente(mantenimientoComponenteNuevo);
            }
            if (seHaceCambioCabezal)
            {
                ImpresoraComponente impresoraComponenteCabecera = new ImpresoraComponente();
                impresoraComponenteCabecera.ImpresoraId = impresoraActualizar.Id;
                impresoraComponenteCabecera.ComponenteId = CambioComponenteCabezal.Id;
                impresoraComponenteCabecera.EstadoId = 10;
                _repositorioImpresoraComponente.AddImpresoraComponente(impresoraComponenteCabecera);
                IEnumerable<ImpresoraComponente> impCom = _repositorioImpresoraComponente.GetImpresoraComponenteByImpresoraIdTipoCabezal(ServicioTecnico.ImpresoraId);
                ImpresoraComponente impresoraComponente = impCom.Last();
                CambioComponente cambioComponente = new CambioComponente();
                cambioComponente.ServicioTecnicoId = ServicioTecnico.Id;
                cambioComponente.ImpresoraComponenteId = impresoraComponente.Id;
                _repositorioCambioComponente.AddCambioComponente(cambioComponente);
            }
            if (seHaceCambioExtrusor)
            {
                ImpresoraComponente impresoraComponenteExtrusor = new ImpresoraComponente();
                impresoraComponenteExtrusor.ImpresoraId = impresoraActualizar.Id;
                impresoraComponenteExtrusor.ComponenteId = CambioComponenteExtrusor.Id;
                impresoraComponenteExtrusor.EstadoId = 13;
                _repositorioImpresoraComponente.AddImpresoraComponente(impresoraComponenteExtrusor);
                IEnumerable<ImpresoraComponente> impCom = _repositorioImpresoraComponente.GetImpresoraComponenteByImpresoraIdTipoExtrusor(ServicioTecnico.ImpresoraId);
                ImpresoraComponente impresoraComponente = impCom.Last();
                CambioComponente cambioComponente = new CambioComponente();
                cambioComponente.ServicioTecnicoId = ServicioTecnico.Id;
                cambioComponente.ImpresoraComponenteId = impresoraComponente.Id;
                _repositorioCambioComponente.AddCambioComponente(cambioComponente);
            }
            if (seHaceCambioCama)
            {
                ImpresoraComponente impresoraComponenteCama = new ImpresoraComponente();
                impresoraComponenteCama.ImpresoraId = impresoraActualizar.Id;
                impresoraComponenteCama.ComponenteId = CambioComponenteCama.Id;
                impresoraComponenteCama.EstadoId = 16;
                _repositorioImpresoraComponente.AddImpresoraComponente(impresoraComponenteCama);
                IEnumerable<ImpresoraComponente> impCom = _repositorioImpresoraComponente.GetImpresoraComponenteByImpresoraIdTipoCama(ServicioTecnico.ImpresoraId);
                ImpresoraComponente impresoraComponente = impCom.Last();
                CambioComponente cambioComponente = new CambioComponente();
                cambioComponente.ServicioTecnicoId = ServicioTecnico.Id;
                cambioComponente.ImpresoraComponenteId = impresoraComponente.Id;
                _repositorioCambioComponente.AddCambioComponente(cambioComponente);
            }
            if (seHaceCambioFuente)
            {
                ImpresoraComponente impresoraComponenteFuente = new ImpresoraComponente();
                impresoraComponenteFuente.ImpresoraId = impresoraActualizar.Id;
                impresoraComponenteFuente.ComponenteId = CambioComponenteFuente.Id;
                impresoraComponenteFuente.EstadoId = 1;
                _repositorioImpresoraComponente.AddImpresoraComponente(impresoraComponenteFuente);
                IEnumerable<ImpresoraComponente> impCom = _repositorioImpresoraComponente.GetImpresoraComponenteByImpresoraIdTipoFuente(ServicioTecnico.ImpresoraId);
                ImpresoraComponente impresoraComponente = impCom.Last();
                CambioComponente cambioComponente = new CambioComponente();
                cambioComponente.ServicioTecnicoId = ServicioTecnico.Id;
                cambioComponente.ImpresoraComponenteId = impresoraComponente.Id;
                _repositorioCambioComponente.AddCambioComponente(cambioComponente);
            }
            _repositorioImpresora.UpdateImpresora(impresoraActualizar);
            return Page();
        }
    }
}
