using System;
using Impresoras3D.App.Dominio;
using Impresoras3D.App.Persistencia;

public class program
{

    private static IRepositorioAuxiliar _repositorioAuxiliar = new RepositorioAuxiliar ( new Impresoras3D.App.Persistencia.AppContext());

    private static void Main(string [] args)
    {

        Console.WriteLine("Hola mundo . Net");

        EliminarAuxiliar();


    }

    private static void AdicionarAuxiliar()
    {

        var Auxiliar = new Auxiliar();

        Auxiliar.Documento = 1012345672;

        Auxiliar.PrimerNombre = "Juan";

        Auxiliar.SegundoNombre = "Sebastian";

        Auxiliar.PrimerApellido = "Lozano";

        Auxiliar.FechaNacimiento = DateTime.Now;

        Auxiliar.telefono = "3123586759";
        
        _repositorioAuxiliar.AddAuxiliar(Auxiliar);

        Console.Write("Auxiliar Adicionado!");
    }

    private static void BuscarAuxiliar()
    {
        Console.WriteLine("***********");
        Console.WriteLine("Buscando Usuario con Documento 1014477563");

        var auxiliar = _repositorioAuxiliar.getAuxiliar(1014477563);

        Console.WriteLine("Nombre: " + auxiliar.PrimerNombre);

        Console.WriteLine("Telefono: "+ auxiliar.telefono);
    }
    
    private static void VerListadoAuxiliares()
    {
        var listaAuxiliares = _repositorioAuxiliar.GetAllAuxiliar();

        foreach (var aux in listaAuxiliares)
        {
           Console.WriteLine("Nombre: " + aux.PrimerNombre);

            Console.WriteLine("Telefono: "+ aux.telefono);

            Console.WriteLine("----------------");
        }
    }

    public static void EliminarAuxiliar()
    {
        _repositorioAuxiliar.DeleteAuxiliar(1014477563);
        Console.WriteLine("Auxiliar eliminado!");
    }

}