using System.ComponentModel.DataAnnotations;

namespace LarreaPaulTaller1.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public int Titulos { get; set; }
        public bool AceptaExtranjetos { get; set; }

    }
}
