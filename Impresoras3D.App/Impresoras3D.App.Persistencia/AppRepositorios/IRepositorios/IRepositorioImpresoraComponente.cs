using System;
using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{
    public interface IRepositorioImpresoraComponente
    {
        public ImpresoraComponente AddImpresoraComponente(ImpresoraComponente ImpresoraComponente);
        public void DeleteImpresoraComponente(int idImpresoraComponente);
        public ImpresoraComponente getImpresoraComponente(int idImpresoraComponente);
        public IEnumerable<ImpresoraComponente> GetAllImpresoraComponente();
        public ImpresoraComponente UpdateImpresoraComponente(
            ImpresoraComponente ImpresoraComponente
        );        
        public IEnumerable<ImpresoraComponente> GetImpresoraComponenteByImpresoraIdTipoCabezal(int impresoraId);
        public IEnumerable<ImpresoraComponente> GetImpresoraComponenteByImpresoraIdTipoExtrusor(int impresoraId);
        public IEnumerable<ImpresoraComponente> GetImpresoraComponenteByImpresoraIdTipoCama(int impresoraId);
        public IEnumerable<ImpresoraComponente> GetImpresoraComponenteByImpresoraIdTipoFuente(int impresoraId);
    }
}
