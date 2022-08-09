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
        public async Task<ActionResult<List<Object>>> getOceanImportList()
        {
            var result = await _context.T_OIMMAIN
                            .GroupJoin(_context.T_OIHMAIN, 
                                x => x.F_ID, 
                                y => y.F_OIMMAINID, 
                                (x, y) => new { oim = x, oih = y })
                            .SelectMany(
                                z => z.oih.DefaultIfEmpty(),
                                (x, y) => new { oim = x.oim, oih = y })
                            .ToListAsync();

            return Ok(result);
        }

        [HttpGet]
        [Route("getOimDetail/{id}")]
        public async Task<ActionResult<List<Object>>> getOceanImportDetail(string id)
        {
            var result = await _context.T_OIMMAIN
                            .GroupJoin(_context.T_OIHMAIN,
                                x => x.F_ID,
                                y => y.F_OIMMAINID,
                                (x, y) => new { oim = x, oih = y })
                            .Where(x => x.oim.F_RefNo == id)
                            .SelectMany(
                                z => z.oih.DefaultIfEmpty(),
                                (x, y) => new { oim = x.oim, oih = y })
                            .ToListAsync();

            return Ok(result);
        }
    }
}
