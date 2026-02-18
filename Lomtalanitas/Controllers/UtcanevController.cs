using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Lomtalanitas.Data;
using Lomtalanitas.Models;

namespace Lomtalanitas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtcanevController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UtcanevController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<object>>> SearchUtcanevek(string name)
        {
            var utcanevek = await _context.Utcanevek
                .Include(u => u.Korzet)  // join a Korzet táblával
                .Where(u => u.UtcaNev != null && u.UtcaNev.Contains(name))
                .Select(u => new
                {
                    u.UtcaNev,
                    KorzetSzam = u.Korzet != null ? u.Korzet.KorzetSzam : "",
                    LomtalanitasDatum = u.Korzet != null ? u.Korzet.LomtalanitasDatum : (DateTime?)null
                })
                .ToListAsync();

            if (!utcanevek.Any())
                return NotFound();

            return Ok(utcanevek);
        }
    }
}