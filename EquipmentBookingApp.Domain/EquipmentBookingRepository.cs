using EquipmentBookingApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EquipmentBookingApp.Domain
{
    public class EquipmentBookingRepository : IEquipmentBookingRepository
    {
        private readonly ILogger<EquipmentBookingRepository> _logger;
        private readonly EquipmentBookingDbContext _context;

        public EquipmentBookingRepository(ILogger<EquipmentBookingRepository> logger, EquipmentBookingDbContext context)
        {
            this._logger = logger;
            this._context = context;
        }

        public async Task<Equipment> GetEquipment(int Id)
        {
            return await _context.Equipment.FirstOrDefaultAsync(q => q.Id.Equals(Id));
        }

        public async Task<IEnumerable<Equipment>> GetEquipment()
        {
            return await _context.Equipment.ToListAsync();
        }

        public async Task<IEnumerable<Equipment>> GetEquipmentByCategory(string category)
        {
            _logger.LogInformation("Returning all Equipment with category {category}", category);
            return await _context.Equipment.Where(q => q.Category.Equals(category)).ToListAsync();
        }
    }
}
