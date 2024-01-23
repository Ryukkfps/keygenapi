using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KeyGen.Data;
using KeyGen.Models;

namespace KeyGen.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PapersController : ControllerBase
    {
        private readonly KeyGeneratorDBContext _context;

        public PapersController(KeyGeneratorDBContext context)
        {
            _context = context;
        }

        // GET: api/Papers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Paper>>> GetPapers()
        {
          if (_context.Papers == null)
          {
              return NotFound();
          }
            return await _context.Papers.ToListAsync();
        }

        // GET: api/Papers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Paper>> GetPaper(int id)
        {
          if (_context.Papers == null)
          {
              return NotFound();
          }
            var paper = await _context.Papers.FindAsync(id);

            if (paper == null)
            {
                return NotFound();
            }

            return paper;
        }

        // PUT: api/Papers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPaper(int id, Paper paper)
        {
            if (id != paper.Paper_Id)
            {
                return BadRequest();
            }

            _context.Entry(paper).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaperExists(id))
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

        // POST: api/Papers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Paper>> PostPaper(Paper paper)
        {
          if (_context.Papers == null)
          {
              return Problem("Entity set 'KeyGeneratorDBContext.Papers'  is null.");
          }
            _context.Papers.Add(paper);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPaper", new { id = paper.Paper_Id }, paper);
        }

        // DELETE: api/Papers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePaper(int id)
        {
            if (_context.Papers == null)
            {
                return NotFound();
            }
            var paper = await _context.Papers.FindAsync(id);
            if (paper == null)
            {
                return NotFound();
            }

            _context.Papers.Remove(paper);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PaperExists(int id)
        {
            return (_context.Papers?.Any(e => e.Paper_Id == id)).GetValueOrDefault();
        }
    }
}
