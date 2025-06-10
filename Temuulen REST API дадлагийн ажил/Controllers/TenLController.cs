using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Temuulen_REST_API_дадлагийн_ажил.Data;

namespace Temuulen_REST_API_дадлагийн_ажил.Controllers
{
    public class TenLController : ControllerBase
    {
        private readonly AppDbContext _context;
        public TenLController(AppDbContext context) => _context = context;

        [HttpGet("api/[controller]")]
        public async Task<IActionResult> GetAll() => Ok(await _context.TEN_L.ToListAsync());
    }
}
