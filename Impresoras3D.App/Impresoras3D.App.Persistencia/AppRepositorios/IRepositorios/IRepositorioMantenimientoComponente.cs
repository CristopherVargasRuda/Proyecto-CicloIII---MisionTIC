using System;
using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{

    public interface IRepositorioMantenimientoComponente
    {
        public MantenimientoComponente AddMantenimientoComponente(MantenimientoComponente MantenimientoComponente);
        public void DeleteMantenimientoComponente(int idServicioTecnico, int idImpresoraComponente);
        public MantenimientoComponente getMantenimientoComponente(int idServicioTecnico, int idImpresoraComponente);
        public IEnumerable<MantenimientoComponente> GetAllMantenimientoComponente();
        
        //duda!
        //public MantenimientoComponente UpdateMantenimientoComponente(MantenimientoComponente MantenimientoComponente);
    }
}