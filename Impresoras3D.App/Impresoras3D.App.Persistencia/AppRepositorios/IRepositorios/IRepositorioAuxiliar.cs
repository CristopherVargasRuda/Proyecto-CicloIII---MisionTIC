using System;

using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{

    public interface IRepositorioAuxiliar
    {
        public Auxiliar AddAuxiliar(Auxiliar Auxiliar);

        public void DeleteAuxiliar (int documentoAuxiliar);

        public Auxiliar getAuxiliar (int documentoAuxiliar);

        public IEnumerable <Auxiliar> GetAllAuxiliar();

        public Auxiliar UpdateAuxiliar(Auxiliar Auxiliar);



    }


}