using FMS_API.Data;
using FMS_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipmentsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ShipmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("getOceanImportList")]
        public async Task<ActionResult<List<T_OIMMAIN>>> getOceanImportList()
        {
            var result = await _context.T_OIMMAIN
                                .Join(_context.T_OIHMAIN, 
                                    oim => oim.F_ID, 
                                    oih => oih.F_OIMMAINID, 
                                (oim, oih) => new { oim, oih }).ToListAsync();
            return Ok(result);
        }
    }
}
