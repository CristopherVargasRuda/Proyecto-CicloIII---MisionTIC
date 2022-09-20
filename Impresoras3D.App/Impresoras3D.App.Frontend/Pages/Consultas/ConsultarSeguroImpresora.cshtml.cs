using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Impresoras3D.App.Dominio;
using Impresoras3D.App.Persistencia;
using System.Globalization;

namespace Impresoras3D.App.Frontend.Pages
{
    public class ConsultarSeguroImpresoraModel : PageModel
    {
        private static IRepositorioCompraSeguro _repositorioCompraSeguro =
            new RepositorioCompraSeguro(new Impresoras3D.App.Persistencia.AppContext());

        private static IRepositorioImpresora _repositorioImpresora = new RepositorioImpresora(
            new Impresoras3D.App.Persistencia.AppContext()
        );

        private static IRepositorioSeguro _repositorioSeguro = new RepositorioSeguro(
            new Impresoras3D.App.Persistencia.AppContext()
        );

        private static IRepositorioSeguroYTipoCubrimiento _repositorioSeguroYTipoCubrimiento =
            new RepositorioSeguroYTipoCubrimiento(new Impresoras3D.App.Persistencia.AppContext());

        private static IRepositorioTipoCubrimiento _repositorioTipoCubrimiento =
            new RepositorioTipoCubrimiento(new Impresoras3D.App.Persistencia.AppContext());

        [BindProperty]
        public Seguro seguroObtenido { get; set; }

        [BindProperty]
        public CompraSeguro compraSeguroObtenido { get; set; }

        [BindProperty]
        public Impresora impresoraObtenida { get; set; }

        [BindProperty]
        public SeguroYTipoCubrimiento seguroYTipoCubrimientoObtenido { get; set; }

        [BindProperty]
        public TipoCubrimiento tipoCubrimientoObtenido { get; set; }

        public DateTime fechaActual = DateTime.Now;

        [BindProperty]
        public int comparacionFechas { get; set; }

        public void OnGet(int id)
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
                IEnumerable<CompraSeguro> ComprasSeguros =
                    _repositorioCompraSeguro.getCompraSeguroByImpresoraId(id);

                compraSeguroObtenido = ComprasSeguros.First();

                seguroObtenido = _repositorioSeguro.getSeguro(compraSeguroObtenido.SeguroId);

                impresoraObtenida = _repositorioImpresora.getImpresora(id);

                seguroYTipoCubrimientoObtenido =
                    _repositorioSeguroYTipoCubrimiento.getSeguroYTipoCubrimientobySeguroId(
                        seguroObtenido.Id
                    );

                tipoCubrimientoObtenido = _repositorioTipoCubrimiento.getTipoCubrimiento(
                    seguroYTipoCubrimientoObtenido.TipoCubrimientoId
                );

                comparacionFechas = DateTime.Compare(fechaActual, compraSeguroObtenido.FechaVencimiento);

                Console.Out.WriteLine(comparacionFechas);

                if(comparacionFechas >= 0)
                {
                    ViewData["Seguro"] = "El seguro está vencido!";
                
                }
            }
            catch (Exception e)
            {
                ViewData["Seguro"] = "Esta Impresora no tiene seguro";
            }
        }

        public ActionResult OnPost()
        {
            Console.Out.WriteLine(TempData["TipoUsuario"]);
            try
            {
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
            }
            catch (System.Exception e)
            {
                return Page();
            }
        }
    }
}
