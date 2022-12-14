using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Impresoras3D.App.Dominio;
using Impresoras3D.App.Persistencia;

namespace Impresoras3D.App.Frontend.Pages
{
    public class RegistrarCompraSeguroModel : PageModel
    {
        private static IRepositorioCompraSeguro _repositorioCompraSeguro = new RepositorioCompraSeguro(new Impresoras3D.App.Persistencia.AppContext());
        private static IRepositorioImpresora _repositorioImpresora = new RepositorioImpresora(new Impresoras3D.App.Persistencia.AppContext());
        private static IRepositorioSeguro _repositorioSeguro = new RepositorioSeguro(new Impresoras3D.App.Persistencia.AppContext());
        private static IRepositorioTipoCubrimiento _repositorioTipoCubrimiento = new RepositorioTipoCubrimiento(new Impresoras3D.App.Persistencia.AppContext());
        private static IRepositorioSeguroYTipoCubrimiento _repositorioSeguroYTipoCubrimiento = new RepositorioSeguroYTipoCubrimiento(new Impresoras3D.App.Persistencia.AppContext());
        [BindProperty]
        public IEnumerable<Impresora> Impresoras { get; set; }
        [BindProperty]
        public IEnumerable<Seguro> Seguros { get; set; }
        [BindProperty]
        public IEnumerable<SeguroYTipoCubrimiento> SeguroYTipoCubrimientos { get; set; }
        [BindProperty]
        public IEnumerable<TipoCubrimiento> TipoCubrimientos { get; set; }
        [BindProperty]
        public CompraSeguro CompraSeguro { get; set; }
        [BindProperty]
        public String espacio { get; set; }
        public RegistrarCompraSeguroModel()
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
            Seguros = _repositorioSeguro.GetAllSeguro();
            TipoCubrimientos = _repositorioTipoCubrimiento.GetAllTipoCubrimiento();
            SeguroYTipoCubrimientos = _repositorioSeguroYTipoCubrimiento.GetAllSeguroYTipoCubrimiento();
            espacio = " - ";

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
                if (DateTime.Compare(CompraSeguro.FechaCompra, CompraSeguro.FechaVencimiento) >= 0)
                {
                    @ViewData["Error"] = "La fecha de vencimiento tiene que ser mayor a la de compra";
                    Impresoras = _repositorioImpresora.GetAllImpresora();
                    Seguros = _repositorioSeguro.GetAllSeguro();
                    TipoCubrimientos = _repositorioTipoCubrimiento.GetAllTipoCubrimiento();
                    SeguroYTipoCubrimientos = _repositorioSeguroYTipoCubrimiento.GetAllSeguroYTipoCubrimiento();
                    espacio = " - ";
                    return Page();
                }
                CompraSeguro CompraSeguroAgregado = _repositorioCompraSeguro.AddCompraSeguro(this.CompraSeguro);

                switch (TempData["TipoUsuario"])
                {
                    case "Tecnico":
                        return RedirectToPage("../Login/LogueoTecnico");
                        break;
                    case "Operario":
                        return RedirectToPage("../Login/LogueoOperario");
                        break;
                    case "SocioEmpresa":
                        return RedirectToPage("../Login/LogueoSocioEmpresa");
                        break;
                    case "Auxiliar":
                        return RedirectToPage("../Login/LogueoAuxiliar");
                        break;
                    case "JefeOperaciones":
                        return RedirectToPage("../Login/LogueoJefeOperaciones");
                        break;
                    default:
                        return RedirectToPage("../Index");
                        break;
                }

                return RedirectToPage("../Index");
            }
            catch (System.Exception e)
            {
                Impresoras = _repositorioImpresora.GetAllImpresora();
                Seguros = _repositorioSeguro.GetAllSeguro();
                TipoCubrimientos = _repositorioTipoCubrimiento.GetAllTipoCubrimiento();
                SeguroYTipoCubrimientos = _repositorioSeguroYTipoCubrimiento.GetAllSeguroYTipoCubrimiento();
                espacio = " - ";
                return Page();
            }
        }
    }
}
