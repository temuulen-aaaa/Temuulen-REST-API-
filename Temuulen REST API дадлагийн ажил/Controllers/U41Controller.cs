using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Temuulen_REST_API_дадлагийн_ажил.Data;
using Temuulen_REST_API_дадлагийн_ажил.Models;

namespace Temuulen_REST_API_дадлагийн_ажил.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class U41Controller : ControllerBase
    {
        private readonly AppDbContext _context;
        public U41Controller(AppDbContext context) => _context = context;

        // GET api/U41
        [HttpGet]
        public async Task<IActionResult> GetAll() =>
            Ok(await _context.U41.ToListAsync());

        // GET api/U41/1234567
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var item = await _context.U41.FindAsync(id);
            return item is null ? NotFound() : Ok(item);
        }

        // POST api/U41
        [HttpPost]
        public async Task<IActionResult> Create(U41 dto)
        {
            _context.U41.Add(dto);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = dto.U41EE }, dto);
        }

        // PUT api/U41/1234567
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, U41 dto)
        {
            if (id != dto.U41EE) return BadRequest("ID mismatch");

            _context.Entry(dto).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE api/U41/1234567
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var item = await _context.U41.FindAsync(id);
            if (item is null) return NotFound();

            _context.U41.Remove(item);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // --- Тусгай update-ууд ---
        [HttpPatch("{id}/department")]
        public async Task<IActionResult> UpdateDepartment(string id, [FromBody] string departmentCode)
        {
            var item = await _context.U41.FindAsync(id);
            if (item is null) return NotFound();

            item.U41CC = departmentCode;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPatch("{id}/email")]
        public async Task<IActionResult> UpdateEmail(string id, [FromBody] string email)
        {
            var item = await _context.U41.FindAsync(id);
            if (item is null) return NotFound();

            item.U41TT = email;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPatch("{id}/group")]
        public async Task<IActionResult> UpdateGroup(string id, [FromBody] int group)
        {
            var item = await _context.U41.FindAsync(id);
            if (item is null) return NotFound();

            item.U41TGroup = group;
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
