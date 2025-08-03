using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstTaskR.api
{
    [ApiController]
    [Route("api/[controller]")]
    public class ObjectsController : ControllerBase
    {
        private readonly DataContext _context;

        public ObjectsController(DataContext context) => _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Shared.Data.Tables.Object>>> GetObjects()
        {
            return await _context.objects.ToListAsync();
        }
    }
}


