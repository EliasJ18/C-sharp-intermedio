using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicApi.Contexts;
using MusicApi.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MusicApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ArtistasController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Artista>> Get()
        {
            return _context.Artistas.Include(x => x.Canciones).ToList();
        }

        [HttpGet ("{id}", Name = "ObtenerArtista")]
        public ActionResult<Artista> get(int id)
        {
            var artista = _context.Artistas.Include(x => x.Canciones).FirstOrDefault(x => x.Id == id);

            if (artista == null)
            {
                return NotFound();
            }
            return artista;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Artista artista)
        {
            _context.Artistas.Add(artista);
            _context.SaveChanges();
            return new CreatedAtRouteResult("ObtenerArtista", new {id = artista.Id}, artista);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Artista value)
        {
            if (id != value.Id)
            {
                return BadRequest();
            }

            _context.Entry(value).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult<Artista> Delete(int id)
        {
            var artista = _context.Artistas.FirstOrDefault(x => x.Id == id);

            if (artista == null)
            {
                return NotFound();
            }

            _context.Artistas.Remove(artista);
            _context.SaveChanges();
            return artista;
        }
    }
}
