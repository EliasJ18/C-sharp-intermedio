using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicApi.Contexts;
using MusicApi.Entities;
using MusicApi.Migrations;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace MusicApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CancionesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CancionesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public ActionResult<IEnumerable<Cancion>> Get()
        {
            return _context.Canciones.Include(x => x.Artista).ToList();
        }

        [HttpGet ("id", Name = "ObtenerCancion")]
        public ActionResult<Cancion> Get(int id)
        {
            var cancion = _context.Canciones.FirstOrDefault(x => x.Id == id);

            if (cancion == null)
            {
                return NotFound();
            }

            return cancion;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Cancion cancion)
        {
            _context.Canciones.Add(cancion);
            _context.SaveChanges();
            return new CreatedAtRouteResult("ObtenerCancion", new {id = cancion.Id}, cancion);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Cancion song)
        {
            if (id != song.Id)
            {
                return BadRequest();
            }

            _context.Entry(song).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Cancion> Delete(int id)
        {
            var cancion = _context.Canciones.FirstOrDefault(x => x.Id == id);

            if (cancion == null)
            {
                return NotFound();
            }

            _context.Canciones.Remove(cancion);
            _context.SaveChanges();
            return cancion;
        }
    }
}
