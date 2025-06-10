using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Temuulen_REST_API_дадлагийн_ажил.Data;

namespace Temuulen_REST_API_дадлагийн_ажил.Controllers
{
    public class AtaLController : ControllerBase
    {
        private readonly AppDbContext _context;
        public AtaLController(AppDbContext context) => _context = context;

        [HttpGet("api/[controller]")]
        public async Task<IActionResult> GetAll() => Ok(await _context.ATA_L.ToListAsync());
    }

}
