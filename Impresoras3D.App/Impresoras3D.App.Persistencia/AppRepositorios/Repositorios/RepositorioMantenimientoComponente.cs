using System;
using Impresoras3D.App.Dominio;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Impresoras3D.App.Persistencia
{

    public class RepositorioMantenimientoComponente : IRepositorioMantenimientoComponente
    {
        //Conexion base de datos
        private readonly AppContext _appContext;
        public RepositorioMantenimientoComponente(AppContext appContext)
        {
            this._appContext = appContext;
        }
        public MantenimientoComponente AddMantenimientoComponente(MantenimientoComponente MantenimientoComponente)
        {
            //Adicionamos el usuario a la base de datos:
            var MantenimientoComponenteAdicionado = this._appContext.MantenimientoComponentes.Add(MantenimientoComponente);
            this._appContext.SaveChanges();
            return MantenimientoComponenteAdicionado.Entity;
        }

        public void DeleteMantenimientoComponente(int idServicioTecnico, int idImpresoraComponente)
        {
            
            var mantenimientoComponente = this._appContext.MantenimientoComponentes.FirstOrDefault(m => m.ServicioTecnicoId == idServicioTecnico && m.ImpresoraComponenteId == idImpresoraComponente);
            
            if (mantenimientoComponente == null)
            {
                return;
            }
            
            this._appContext.MantenimientoComponentes.Remove(mantenimientoComponente);
            
            this._appContext.SaveChanges();
        }


        public MantenimientoComponente getMantenimientoComponente(int idServicioTecnico, int idImpresoraComponente)
        {
            var mantenimientoComponente = this._appContext.MantenimientoComponentes.FirstOrDefault(m => m.ServicioTecnicoId == idServicioTecnico && m.ImpresoraComponenteId == idImpresoraComponente);

            return mantenimientoComponente;
        }


        public IEnumerable<MantenimientoComponente> GetAllMantenimientoComponente()
        {
            return this._appContext.MantenimientoComponentes;
        }
    }
}

