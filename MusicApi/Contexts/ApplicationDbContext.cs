using Microsoft.EntityFrameworkCore;
using MusicApi.Entities;

namespace MusicApi.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {

        }

        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Cancion> Canciones { get; set; }
    }
}
