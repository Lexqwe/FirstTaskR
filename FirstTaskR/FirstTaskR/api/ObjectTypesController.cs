using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FirstTaskR;
using FirstTaskR.Shared.Data.Tables;

namespace FirstTask_rk.api.ObjectTypesController
{
    [ApiController]
    [Route("api/[controller]")]
    public class ObjectTypesController : ControllerBase
    {
        private readonly DataContext _context;

        public ObjectTypesController(DataContext context) => _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ObjectType>>> GetTypes()
        {
            return await _context.object_types.ToListAsync();
        }
    }
}
