using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Autor
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }

    }
}
