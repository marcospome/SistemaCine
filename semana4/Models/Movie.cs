using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Pelicula
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El título es obligatorio.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "El género es obligatorio.")]
        public Genero Genero { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "La fecha de estreno es obligatoria.")]
        public DateTime FechaEstreno { get; set; }

        [Required(ErrorMessage = "El director es obligatorio.")]
        public string Director { get; set; }

        [Required(ErrorMessage = "La sinopsis es obligatoria.")]
        public string Sinopsis { get; set; }

        [Required(ErrorMessage = "La duración es obligatoria.")]
        public int Duracion { get; set; }

        [Required(ErrorMessage = "El afiche es obligatorio.")]
        public string Afiche { get; set; }

        [Required(ErrorMessage = "La clasificación es obligatoria.")]
        public Clasificacion Clasificacion { get; set; }
    }

    public class Genero
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del género es obligatorio.")]
        public string Nombre { get; set; }
    }

    public class Clasificacion
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la clasificación es obligatorio.")]
        public string Nombre { get; set; }
    }
}
