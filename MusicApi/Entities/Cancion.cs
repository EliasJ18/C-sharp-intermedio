using System.ComponentModel.DataAnnotations;

namespace MusicApi.Entities
{
    public class Cancion
    {
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public int ArtistaId { get; set; }
        public Artista Artista { get; set; }
        public string Genero { get; set; }

    }
}
