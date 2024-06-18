using semana4.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Pelicula
{
    [Key]
    public int PeliculaId { get; set; }

    [Required]
    [StringLength(100)]
    public string Titulo { get; set; }

    [Required]
    public string Director { get; set; }

    [DataType(DataType.Date)]
    public DateTime FechaDeLanzamiento { get; set; }

    [Range(1, 500)]
    public int Duracion { get; set; } // Duración en minutos

    [Required]
    [StringLength(500)]
    public string Sinopsis { get; set; }

    [Required]
    public string Portada { get; set; }

    [Required]
    public int GeneroId { get; set; }

    [Required]
    public int ClasificacionId { get; set; }

    public ICollection<Funcion> Funciones { get; set; }
}

public class Genero
{
    [Key]
    public int GeneroId { get; set; }
    [Required]
    public string Nombre { get; set; }
    public ICollection<Pelicula> Peliculas { get; set; }
}

public class Clasificacion
{
    [Key]
    public int ClasificacionId { get; set; }
    [Required]
    public string Nombre { get; set; }
    public ICollection<Pelicula> Peliculas { get; set; }
}