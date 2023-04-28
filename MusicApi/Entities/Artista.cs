using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace MusicApi.Entities
{
    public class Artista
    {
       public int Id { get; set; }
       [Required]
       public string Name { get; set; }
       public List<Cancion> Canciones { get; set; }
    }
}
