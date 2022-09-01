using System;

using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{

    public class RepositorioAuxiliar : IRepositorioAuxiliar
    {

        //Conexion base de datos

        private readonly AppContext _appContext;

        public RepositorioAuxiliar(AppContext appContext)
        {
            this._appContext = appContext;
        }


        public Auxiliar AddAuxiliar (Auxiliar auxiliar)
        {
            //Adicionamos el usuario a la base de datos:

            var auxiliarAdicionado = this._appContext.Auxiliares.Add(auxiliar);

            this._appContext.SaveChanges();

            return auxiliarAdicionado.Entity;
        }

        public void DeleteAuxiliar (int idAuxiliar)
        {

            //buscamos el auxiliar en la base de datos segun su id que es el documento

            var auxiliar = this._appContext.Auxiliares.FirstOrDefault ( a => a.Id == idAuxiliar);

            //se confirma que no es nula la variable

            if(auxiliar == null)
            {
                return;
            }


            //borramos el auxiliar
            this._appContext.Auxiliares.Remove(auxiliar);

            //guardamos

            this._appContext.SaveChanges();
        }


        public Auxiliar getAuxiliar ( int idAuxiliar)
        {

            var auxiliar = this._appContext.Auxiliares.FirstOrDefault ( a => a.Id == idAuxiliar);

            return auxiliar;
        }


        public IEnumerable<Auxiliar> GetAllAuxiliar()
        {
            return this._appContext.Auxiliares;
        }


        public Auxiliar UpdateAuxiliar (Auxiliar auxiliar)
        {

            // se conecta a la base de datos y se busca el usuario

            var auxiliarEncontrado = this._appContext.Auxiliares.FirstOrDefault( a => a.Id == auxiliar.Id);

            //Si no esta vacio cabiammos los valores

            if( auxiliarEncontrado !=null)
            {

                auxiliarEncontrado.Documento = auxiliar.Documento;

                auxiliarEncontrado.PrimerNombre = auxiliar.PrimerNombre;

                auxiliarEncontrado.SegundoNombre = auxiliar.SegundoNombre;

                auxiliarEncontrado.PrimerApellido = auxiliar.PrimerApellido;

                auxiliarEncontrado.SegundoApellido = auxiliar.SegundoApellido;

                auxiliarEncontrado.FechaNacimiento = auxiliar.FechaNacimiento;

                auxiliarEncontrado.telefono = auxiliar.telefono;

                //guardaos cambios

                this._appContext.SaveChanges();

                
            }

            return auxiliarEncontrado;
        }





    }


}