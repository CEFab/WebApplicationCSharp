using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Articulo
    {
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        [ForeignKey("Autor")]
        public int IdAutor { get; set; }
        public Autor Autor { get; set; }
        public string Contenido { get; set; }
        public DateTime Fecha { get; set; }





    }
}
