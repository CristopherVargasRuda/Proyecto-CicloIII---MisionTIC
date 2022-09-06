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

        public Impresora impresoraObtenida { get; set; }

        public Software softwareObtenido { get; set; }

        public Estado estadoSoftwareObtenido { get; set; }

        public Estado estadoImpresoraObtenida { get; set; }


        public ConsultarImpresorasModel() { }

        public ActionResult OnGet()
        {
            return Page();
        }

        public ActionResult OnPost()
        {
            try
            {
                this.impresoraObtenida = _repositorioImpresora.getByPlaca(
                    Impresora.PlacaInventario
                );

                this.softwareObtenido = _repositorioSoftware.getSoftware(this.impresoraObtenida.SoftwareId); //REVISAR!

                this. estadoImpresoraObtenida = _repositorioEstado.getEstado(3); //REVISAR!!

                this.estadoSoftwareObtenido = _repositorioEstado.getEstado(8); //REVISAR!!
            }
            catch (System.Exception e)
            {
                ViewData["Error"] = e.Message;
                Console.Out.WriteLine(Impresora.PlacaInventario);
            }

            return Page();
        }
    }
}
