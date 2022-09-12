using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Impresoras3D.App.Dominio;
using Impresoras3D.App.Persistencia;

namespace Impresoras3D.App.Frontend.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private static IRepositorioAuxiliar _repositorioAuxiliar = new RepositorioAuxiliar(
        new Impresoras3D.App.Persistencia.AppContext()
    );
    private static IRepositorioJefeOperaciones _repositorioJefeOperaciones =
        new RepositorioJefeOperaciones(new Impresoras3D.App.Persistencia.AppContext());
    private static IRepositorioOperario _repositorioOperario = new RepositorioOperario(
        new Impresoras3D.App.Persistencia.AppContext()
    );
    private static IRepositorioSocioEmpresa _repositorioSocioEmpresa = new RepositorioSocioEmpresa(
        new Impresoras3D.App.Persistencia.AppContext()
    );
    private static IRepositorioTecnico _repositorioTecnico = new RepositorioTecnico(
        new Impresoras3D.App.Persistencia.AppContext()
    );

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
            Auxiliar auxiliar = _repositorioAuxiliar.getByLogin(Persona.Documento, Persona.Password);
            if (auxiliar != null)
            {
                return RedirectToPage("./Login/LogueoAuxiliar");
            }
            else
            {
                JefeOperaciones jefeOperaciones = _repositorioJefeOperaciones.getByLogin(
                    Persona.Documento, Persona.Password
                );
                if (jefeOperaciones != null)
                {
                    return RedirectToPage("./Login/LogueoJefeOperaciones");
                }
                else
                {
                    Operario operario = _repositorioOperario.getByLogin(Persona.Documento, Persona.Password);
                    if (operario != null)
                    {
                        return RedirectToPage("./Login/LogueoOperario");
                    }
                    else
                    {
                        SocioEmpresa socioEmpresa = _repositorioSocioEmpresa.getByLogin(
                            Persona.Documento, Persona.Password
                        );
                        if (socioEmpresa != null)
                        {
                            return RedirectToPage("./Login/LogueoSocioEmpresa");
                        }
                        else
                        {
                            Tecnico tecnico = _repositorioTecnico.getByLogin(Persona.Documento, Persona.Password);
                            if (tecnico != null)
                            {
                                return RedirectToPage("./Login/LogueoTecnico");
                            }else
                            {
                                ViewData["Error"] = "Usuario No Encontrado!";
                                return Page();
                            }
                        }
                    }
                }
            }
        }
        catch (System.Exception e)
        {
            Console.Out.WriteLine(Persona.Documento);
            Console.Out.WriteLine(Persona.Password);
            return Page();
        }
    }
}
