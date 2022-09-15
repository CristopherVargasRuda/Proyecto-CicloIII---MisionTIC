using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Impresoras3D.App.Dominio;
using Impresoras3D.App.Persistencia;

namespace Impresoras3D.App.Frontend.Pages
{
    public class LogueoJefeOperacionesModel : PageModel
    {
        public LogueoJefeOperacionesModel() { }

        public void OnGet()
        {
            if (
                TempData.ContainsKey("Id")
                && TempData.ContainsKey("Nombre")
                && TempData.ContainsKey("TipoUsuario")
            )
            {
                TempData.Keep();
            }
        }
    }
}
