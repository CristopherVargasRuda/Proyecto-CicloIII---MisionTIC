using System;
using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{

    public interface IRepositorioTecnico
    {
        public Tecnico AddTecnico(Tecnico Tecnico);
        public void DeleteTecnico(int idTecnico);
        public Tecnico getTecnico(int idTecnico);
        public IEnumerable<Tecnico> GetAllTecnico();
        public Tecnico UpdateTecnico(Tecnico Tecnico);
        public Tecnico getByDocument(int document); 
        public Tecnico getByLogin(int document, string pass); 
    }
}