using System;

using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{

    public interface IRepositorioTecnico
    {

        public Tecnico AddTecnico(Tecnico Tecnico);

        public void DeleteTecnico (int documentoTecnico);

        public Tecnico getTecnico (int documentoTecnico);

        public IEnumerable <Tecnico> GetAllTecnico();

        public Tecnico UpdateTecnico(Tecnico Tecnico);

    }


}