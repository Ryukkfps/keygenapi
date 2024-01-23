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
    public class AnswerKeysController : ControllerBase
    {
        private readonly KeyGeneratorDBContext _context;

        public AnswerKeysController(KeyGeneratorDBContext context)
        {
            _context = context;
        }

        // GET: api/AnswerKeys
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AnswerKey>>> GetAnswerKeys()
        {
          if (_context.AnswerKeys == null)
          {
              return NotFound();
          }
            return await _context.AnswerKeys.ToListAsync();
        }

        // GET: api/AnswerKeys/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AnswerKey>> GetAnswerKey(int id)
        {
          if (_context.AnswerKeys == null)
          {
              return NotFound();
          }
            var answerKey = await _context.AnswerKeys.FindAsync(id);

            if (answerKey == null)
            {
                return NotFound();
            }

            return answerKey;
        }

        // PUT: api/AnswerKeys/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnswerKey(int id, AnswerKey answerKey)
        {
            if (id != answerKey.AnswerKey_Id)
            {
                return BadRequest();
            }

            _context.Entry(answerKey).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnswerKeyExists(id))
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

        // POST: api/AnswerKeys
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AnswerKey>> PostAnswerKey(AnswerKey answerKey)
        {
          if (_context.AnswerKeys == null)
          {
              return Problem("Entity set 'KeyGeneratorDBContext.AnswerKeys'  is null.");
          }
            _context.AnswerKeys.Add(answerKey);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAnswerKey", new { id = answerKey.AnswerKey_Id }, answerKey);
        }

        // DELETE: api/AnswerKeys/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnswerKey(int id)
        {
            if (_context.AnswerKeys == null)
            {
                return NotFound();
            }
            var answerKey = await _context.AnswerKeys.FindAsync(id);
            if (answerKey == null)
            {
                return NotFound();
            }

            _context.AnswerKeys.Remove(answerKey);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AnswerKeyExists(int id)
        {
            return (_context.AnswerKeys?.Any(e => e.AnswerKey_Id == id)).GetValueOrDefault();
        }
    }
}
