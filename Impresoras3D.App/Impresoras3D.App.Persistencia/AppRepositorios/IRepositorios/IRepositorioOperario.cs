using System;

using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{

    public interface IRepositorioOperario
    {

        public Operario AddOperario(Operario Operario);

        public void DeleteOperario (int idOperario);

        public Operario getOperario (int idOperario);

        public IEnumerable <Operario> GetAllOperario();

        public Operario UpdateOperario(Operario Operario);

    }


}