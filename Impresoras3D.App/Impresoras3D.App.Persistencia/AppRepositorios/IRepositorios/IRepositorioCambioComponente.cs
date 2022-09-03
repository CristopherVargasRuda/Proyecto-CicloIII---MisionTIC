using System;
using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{

    public interface IRepositorioCambioComponente
    {
        public CambioComponente AddCambioComponente(CambioComponente CambioComponente);
        public void DeleteCambioComponente(int idServicioTecnico, int idImpresoraComponente);
        public CambioComponente getCambioComponente(int idServicioTecnico, int idImpresoraComponente);
        public IEnumerable<CambioComponente> GetAllCambioComponente();
        
        //duda!
        //public CambioComponente UpdateCambioComponente(CambioComponente CambioComponente);
    }
}