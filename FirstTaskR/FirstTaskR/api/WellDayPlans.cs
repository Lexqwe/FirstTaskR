using FirstTaskR.Shared.Data.Tables;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FirstTaskR;

namespace FirstTaskR.api
{
    [ApiController]
    [Route("api/[controller]")]
    public class WellDayPlansController : ControllerBase
    {
        private readonly DataContext _context;

        public WellDayPlansController(DataContext context) => _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<WellDayPlan>>> GetWellDayPlans()
        {
            return await _context.well_day_plans.ToListAsync();
        }
    }
}