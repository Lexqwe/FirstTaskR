using FirstTaskR.Shared.Data.Tables;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FirstTaskR;

namespace FirstTaskR.api
{
    [ApiController]
    [Route("api/[controller]")]
    public class WellsController : ControllerBase
    {
        private readonly DataContext _context;

        public WellsController(DataContext context) => _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Well>>> GetWells()
        {
            return await _context.wells.ToListAsync();
        }
    }
}