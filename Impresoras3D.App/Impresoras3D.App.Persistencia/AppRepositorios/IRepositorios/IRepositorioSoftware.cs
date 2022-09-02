using System;

using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{
    public interface IRepositorioSoftware
    {
        public Software AddSoftware(Software Software);

        public void DeleteSoftware(int idSoftware);

        public Software getSoftware(int idSoftware);

        public IEnumerable<Software> GetAllSoftware();

        public Software UpdateSoftware(Software Software);
    }
}
