using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;  // For ICollection

namespace semana4.Models
{
    public class Funcion
    {
        [Key]
        public int IdFuncion { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Dia { get; set; }

        [Required]
        public TimeSpan Horario { get; set; }

        [StringLength(50)]
        public string Lenguaje { get; set; }

        [Required]  // Marca IdPelicula como obligatorio
        public int IdPelicula { get; set; } // Clave foránea
    }
}
