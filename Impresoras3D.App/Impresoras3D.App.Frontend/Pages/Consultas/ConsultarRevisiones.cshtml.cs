using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Impresoras3D.App.Dominio;
using Impresoras3D.App.Persistencia;

namespace Impresoras3D.App.Frontend.Pages
{
    public class ConsultarRevisionesModel : PageModel
    {
        private static IRepositorioImpresora _repositorioImpresora = new RepositorioImpresora(new Impresoras3D.App.Persistencia.AppContext());
        private static IRepositorioServicioTecnico _repositorioServicioTecnico = new RepositorioServicioTecnico(new Impresoras3D.App.Persistencia.AppContext());
        private static IRepositorioTecnico _repositorioTecnico = new RepositorioTecnico(new Impresoras3D.App.Persistencia.AppContext());
        [BindProperty]
        public Impresora Impresora { get; set; }
        [BindProperty]
        public IEnumerable<ServicioTecnico> ServiciosTecnicos { get; set; }
        [BindProperty]
        public IEnumerable<Tecnico> Tecnicos { get; set; }
        public ActionResult OnGet(int id)
        {
            Impresora = _repositorioImpresora.getImpresora(id);
            Tecnicos = _repositorioTecnico.GetAllTecnico();
            ServiciosTecnicos = _repositorioServicioTecnico.GetServiciosTecnicosByImpresoraId(id);
            return Page();
        }
    }
}
