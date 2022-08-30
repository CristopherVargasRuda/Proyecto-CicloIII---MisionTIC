using System;

using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{

    public interface IRepositorioOperario
    {

        public Operario AddOperario(Operario Operario);

        public void DeleteOperario (int documentoOperario);

        public Operario getOperario (int documentoOperario);

        public IEnumerable <Operario> GetAllOperario();

        public Operario UpdateOperario(Operario Operario);

    }


}