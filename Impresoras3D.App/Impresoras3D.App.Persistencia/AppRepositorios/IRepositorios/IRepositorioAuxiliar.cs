using System;
using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{

    public interface IRepositorioAuxiliar
    {
        public Auxiliar AddAuxiliar(Auxiliar Auxiliar);
        public void DeleteAuxiliar(int idAuxiliar);
        public Auxiliar getAuxiliar(int idAuxiliar);
        public IEnumerable<Auxiliar> GetAllAuxiliar();
        public Auxiliar UpdateAuxiliar(Auxiliar Auxiliar);
        public Auxiliar getByDocument(int document);
        public Auxiliar getByLogin(int document, string pass);
    }
}