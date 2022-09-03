using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Impresoras3D.App.Dominio;
using Impresoras3D.App.Persistencia;

namespace Impresoras3D.App.Frontend.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private static IRepositorioAuxiliar _repositorioAuxiliar = new RepositorioAuxiliar(new Impresoras3D.App.Persistencia.AppContext());
    private static IRepositorioJefeOperaciones _repositorioJefeOperaciones = new RepositorioJefeOperaciones(new Impresoras3D.App.Persistencia.AppContext());
    private static IRepositorioOperario _repositorioOperario = new RepositorioOperario(new Impresoras3D.App.Persistencia.AppContext());
    private static IRepositorioSocioEmpresa _repositorioSocioEmpresa = new RepositorioSocioEmpresa(new Impresoras3D.App.Persistencia.AppContext());
    private static IRepositorioTecnico _repositorioTecnico = new RepositorioTecnico(new Impresoras3D.App.Persistencia.AppContext());

    [BindProperty] //Asocia al usuario
    public Persona Persona { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public ActionResult OnGet() // el ActionResult ayuda a devolver la información si hay un error
    {
        return Page();
    }

    public ActionResult OnPost()
    {
        try
        {
            Auxiliar auxiliar = _repositorioAuxiliar.getByDocument(Persona.Documento);
            if (auxiliar != null)
            {
                return RedirectToPage("./Login/LogueoAuxiliar");
            }
            else
            {
                JefeOperaciones jefeOperaciones = _repositorioJefeOperaciones.getByDocument(Persona.Documento);
                if (jefeOperaciones != null)
                {
                    return RedirectToPage("./Login/LogueoJefeOperaciones");
                }
                else
                {
                    Operario operario = _repositorioOperario.getByDocument(Persona.Documento);
                    if (operario != null)
                    {
                        return RedirectToPage("./Login/LogueoOperario");
                    }
                    else
                    {
                        SocioEmpresa socioEmpresa = _repositorioSocioEmpresa.getByDocument(Persona.Documento);
                        if (socioEmpresa != null)
                        {
                            return RedirectToPage("./Login/LogueoSocioEmpresa");
                        }
                        else
                        {
                            Tecnico tecnico = _repositorioTecnico.getByDocument(Persona.Documento);
                            if (tecnico != null)
                            {
                                //Console.Out.WriteLine("Tecnico: " + tecnico.PrimerNombre);
                                return RedirectToPage("./Login/LogueoTecnico");
                            }
                            else
                            {
                                Console.Out.WriteLine("mera lok");
                            }
                        }
                    }
                }
            }

            return Page();
        }
        catch (System.Exception e)
        {
            return Page();
        }
    }

}
