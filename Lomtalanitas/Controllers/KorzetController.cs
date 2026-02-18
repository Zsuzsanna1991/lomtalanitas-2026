using Lomtalanitas.Data;
using Lomtalanitas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lomtalanitas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorzetController : ControllerBase
    {
        private readonly AppDbContext _context;

        public KorzetController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/korzet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Korzet>>> GetKorzetek()
        {
            return await _context.Korzetek.ToListAsync();
        }

        // GET: api/korzet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Korzet>> GetKorzet(int id)
        {
            var korzet = await _context.Korzetek.FindAsync(id);

            if (korzet == null)
                return NotFound();

            return korzet;
        }
    }
}
