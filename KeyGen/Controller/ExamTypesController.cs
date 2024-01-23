﻿using System;
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
    public class ExamTypesController : ControllerBase
    {
        private readonly KeyGeneratorDBContext _context;

        public ExamTypesController(KeyGeneratorDBContext context)
        {
            _context = context;
        }

        // GET: api/ExamTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExamType>>> GetExamTypes()
        {
          if (_context.ExamTypes == null)
          {
              return NotFound();
          }
            return await _context.ExamTypes.ToListAsync();
        }

        // GET: api/ExamTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ExamType>> GetExamType(int id)
        {
          if (_context.ExamTypes == null)
          {
              return NotFound();
          }
            var examType = await _context.ExamTypes.FindAsync(id);

            if (examType == null)
            {
                return NotFound();
            }

            return examType;
        }

        // PUT: api/ExamTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExamType(int id, ExamType examType)
        {
            if (id != examType.Exam_Type_id)
            {
                return BadRequest();
            }

            _context.Entry(examType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExamTypeExists(id))
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

        // POST: api/ExamTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ExamType>> PostExamType(ExamType examType)
        {
          if (_context.ExamTypes == null)
          {
              return Problem("Entity set 'KeyGeneratorDBContext.ExamTypes'  is null.");
          }
            _context.ExamTypes.Add(examType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExamType", new { id = examType.Exam_Type_id }, examType);
        }

        // DELETE: api/ExamTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExamType(int id)
        {
            if (_context.ExamTypes == null)
            {
                return NotFound();
            }
            var examType = await _context.ExamTypes.FindAsync(id);
            if (examType == null)
            {
                return NotFound();
            }

            _context.ExamTypes.Remove(examType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExamTypeExists(int id)
        {
            return (_context.ExamTypes?.Any(e => e.Exam_Type_id == id)).GetValueOrDefault();
        }
    }
}
