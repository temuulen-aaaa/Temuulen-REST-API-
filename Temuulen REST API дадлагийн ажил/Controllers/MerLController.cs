﻿using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Temuulen_REST_API_дадлагийн_ажил.Data;

namespace Temuulen_REST_API_дадлагийн_ажил.Controllers
{
    public class MerLController : ControllerBase
    {
        private readonly AppDbContext _context;
        public MerLController(AppDbContext context) => _context = context;

        [HttpGet("api/[controller]")]
        public async Task<IActionResult> GetAll() => Ok(await _context.MER_L.ToListAsync());
    }
}
