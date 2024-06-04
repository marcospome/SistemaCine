using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace semana4.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Pelicula> Pelicula { get; set; }
        public DbSet<Genero> Genero { get; set; }

        public DbSet<Clasificacion> Clasificacion { get; set; }
    }
}
