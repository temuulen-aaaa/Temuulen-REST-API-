using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Temuulen_REST_API_дадлагийн_ажил.Data;

namespace Temuulen_REST_API_дадлагийн_ажил.Controllers
{
    public class AuthUserController : ControllerBase
    {
        private readonly AppDbContext _context;
        public AuthUserController(AppDbContext context) => _context = context;

        [HttpGet("api/[controller]")]
        public async Task<IActionResult> GetUsersWithEmail()
        {
            var query = from a in _context.AuthUser
                        join u in _context.U41 on a.U41EE equals u.U41EE
                        select new
                        {
                            username = a.UserName,
                            pass = a.Password,
                            email = u.U41TT
                        };

            return Ok(await query.ToListAsync());
        }
    }
}
