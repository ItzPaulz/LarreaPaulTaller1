using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LarreaPaulTaller1.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string posicion { get; set; }
        public int Edad { get; set; }
        public Equipo? Equipo { get; set; }
        [ForeignKey("Equipo")]
        public int IdEquipo { get; set; }
        
    }
}
