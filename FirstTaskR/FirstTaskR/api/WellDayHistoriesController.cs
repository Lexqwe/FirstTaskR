using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FirstTaskR;
using FirstTaskR.Shared.Data.Tables;

namespace FirstTask_rk.api
{
    [ApiController]
    [Route("api/[controller]")]
    public class WellDayHistoriesController : ControllerBase
    {
        private readonly DataContext _context;

        public WellDayHistoriesController(DataContext context) => _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<WellDayHistory>>> GetWellDayHistories()
        {
            return await _context.well_day_histories.ToListAsync();
        }
    }
}
