using System;

using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{
    public interface IRepositorioServicioTecnico
    {
        public ServicioTecnico AddServicioTecnico(ServicioTecnico ServicioTecnico);
        public void DeleteServicioTecnico(int idServicioTecnico);
        public ServicioTecnico getServicioTecnico(int idServicioTecnico);
        public IEnumerable<ServicioTecnico> GetAllServicioTecnico();
        public ServicioTecnico UpdateServicioTecnico(ServicioTecnico ServicioTecnico);
        public IEnumerable<ServicioTecnico> GetServiciosTecnicosByImpresoraId(int impresoraId);
        public ServicioTecnico getLastServicioTecnico();
    }
}
