using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicApi.Entities;

namespace MusicApi.Data
{
    public class MusicApiContext : DbContext
    {
        public MusicApiContext (DbContextOptions<MusicApiContext> options)
            : base(options)
        {
        }

        public DbSet<MusicApi.Entities.Artista> Artista { get; set; }
    }
}
