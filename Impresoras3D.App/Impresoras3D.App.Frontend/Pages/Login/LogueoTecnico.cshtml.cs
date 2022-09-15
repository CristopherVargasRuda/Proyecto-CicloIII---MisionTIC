using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Impresoras3D.App.Dominio;
using Impresoras3D.App.Persistencia;

namespace Impresoras3D.App.Frontend.Pages
{
    public class LogueoTecnicoModel : PageModel
    {
        public LogueoTecnicoModel() { }

        public void OnGet()
        {
            TempData["TipoUsuario"] = "Tecnico";
            TempData.Keep();
        }
    }
}
