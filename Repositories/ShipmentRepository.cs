using FMS_API.Data;
using FMS_API.Entities;
using Microsoft.EntityFrameworkCore;

namespace FMS_API.Repositories
{
    public interface IShipmentRepository
    {
        public Task<List<TC_OIM>> getAllOceanImport();
    }

    public class ShipmentRepository : IShipmentRepository
    {
        private readonly ApplicationDbContext _context;
        public ShipmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<TC_OIM>> getAllOceanImport()
        {
            var result = await _context.T_OIMMAIN
                .AsNoTracking()
                .GroupJoin(_context.T_OIHMAIN,
                    x => x.F_ID,
                    y => y.F_OIMMAINID,
                    (x, y) => new { oim = x, oih = y })
                .SelectMany(
                    z => z.oih.DefaultIfEmpty(),
                    (x, y) => new TC_OIM{ oim = x.oim, oih = y })
                .ToListAsync() ?? new List<TC_OIM>();

            return result;
        }
    }
}
