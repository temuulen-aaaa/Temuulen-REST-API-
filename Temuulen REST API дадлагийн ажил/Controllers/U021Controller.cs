using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Temuulen_REST_API_дадлагийн_ажил.Data;
using Temuulen_REST_API_дадлагийн_ажил.Models;
namespace Temuulen_REST_API_дадлагийн_ажил.Controllers
{
    [ApiController]
    [Route("[controller]")] // This maps to /U021 if your class is U021Controller
    public class U021Controller : ControllerBase
    {
        private readonly AppDbContext _context;

        public U021Controller(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<U021>>> GetAll()
        {
            return await _context.U021s.ToListAsync();
        }
    }
}
