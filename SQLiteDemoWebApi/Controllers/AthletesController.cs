using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLiteDemoWebApi.Contexts;
using SQLiteDemoWebApi.Entities;

namespace SQLiteDemoWebApi.Controllers
{
    [Route("api/Athletes")]
    [ApiController]
    public class AthletesController : ControllerBase
    {
        private readonly AthleteSQLiteDbContext _context;

        public AthletesController(AthleteSQLiteDbContext context)
        {
            _context = context;
        }

        // GET: api/Athletes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Athlete>>> GetAthletes()
        {
            return await _context.Athletes.ToListAsync();
        }

        // GET: api/Athletes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Athlete>> GetAthlete(int id)
        {
            var athlete = await _context.Athletes.FindAsync(id);

            if (athlete == null)
            {
                return NotFound();
            }

            return athlete;
        }

        // PUT: api/Athletes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAthlete(int id, Athlete athlete)
        {
            if (id != athlete.id)
            {
                return BadRequest();
            }

            _context.Entry(athlete).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AthleteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Athletes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Athlete>> PostAthlete(Athlete athlete)
        {
            _context.Athletes.Add(athlete);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAthlete", new { id = athlete.id }, athlete);
        }

        // DELETE: api/Athletes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Athlete>> DeleteAthlete(int id)
        {
            var athlete = await _context.Athletes.FindAsync(id);
            if (athlete == null)
            {
                return NotFound();
            }

            _context.Athletes.Remove(athlete);
            await _context.SaveChangesAsync();

            return athlete;
        }

        private bool AthleteExists(int id)
        {
            return _context.Athletes.Any(e => e.id == id);
        }
    }
}
