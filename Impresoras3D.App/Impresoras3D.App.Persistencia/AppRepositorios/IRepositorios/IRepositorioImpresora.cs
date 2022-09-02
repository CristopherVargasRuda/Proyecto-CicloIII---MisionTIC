using System;

using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{
    public interface IRepositorioImpresora
    {
        public Impresora AddImpresora(Impresora Impresora);

        public void DeleteImpresora(int idImpresora);

        public Impresora getImpresora(int idImpresora);

        public IEnumerable<Impresora> GetAllImpresora();

        public Impresora UpdateImpresora(Impresora Impresora);
    }
}
