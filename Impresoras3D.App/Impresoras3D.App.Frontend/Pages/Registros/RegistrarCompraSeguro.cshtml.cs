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
        public String espacio {get; set;}
        public RegistrarCompraSeguroModel()
        { }
        public ActionResult OnGet()
        {
            Impresoras = _repositorioImpresora.GetAllImpresora();
            Seguros = _repositorioSeguro.GetAllSeguro();
            TipoCubrimientos = _repositorioTipoCubrimiento.GetAllTipoCubrimiento();
            SeguroYTipoCubrimientos = _repositorioSeguroYTipoCubrimiento.GetAllSeguroYTipoCubrimiento();
            espacio = " - ";
            return Page();
        }
        public ActionResult OnPost()
        {
            try
            {
                CompraSeguro CompraSeguroAgregado = _repositorioCompraSeguro.AddCompraSeguro(this.CompraSeguro);
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
