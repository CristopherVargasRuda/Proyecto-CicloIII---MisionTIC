using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{

    [Table("Estado")]
    public class Estado
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Se requiere el Nombre")]
        public string Nombre { get; set; }
        public List<Impresora> Impresoras { get; set; }
        public List<ImpresoraComponente> ImpresoraComponentes { get; set; }
        public List<Software> Softwares { get; set; }
    }
}