using AutoMapper;
using FMS_API.Data;
using FMS_API.Entities;
using FMS_API.Models;
using FMS_API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipmentsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IShipmentRepository _shipmentRepository;

        public ShipmentsController(IShipmentRepository shipmentRepository, IMapper mapper)
        {
            _mapper = mapper;
            _shipmentRepository = shipmentRepository;
        }

        [HttpGet]
        [Route("getOceanImportList")]
        public async Task<IActionResult> getOceanImportList()
        {
            var data = await _shipmentRepository.getAllOceanImport();
            var result = _mapper.Map<List<VM_OIM>>(data);
            return Ok(result);
        }

        [HttpGet]
        [Route("getOimDetail/{id}")]
        public async Task<IActionResult> getOceanImportDetail(string id)
        {
            //var result = await _context.T_OIMMAIN
            //                .GroupJoin(_context.T_OIHMAIN,
            //                    x => x.F_ID,
            //                    y => y.F_OIMMAINID,
            //                    (x, y) => new { oim = x, oih = y })
            //                .Where(x => x.oim.F_RefNo == id)
            //                .SelectMany(
            //                    z => z.oih.DefaultIfEmpty(),
            //                    (x, y) => new { oim = x.oim, oih = y })
            //                .ToListAsync();

            return Ok();
        }
    }
}
