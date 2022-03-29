using EquipmentBookingApp.Domain.Models;
using Microsoft.Extensions.Logging;

namespace EquipmentBookingApp.Domain
{
    public class EquipmentBookingProcessor : IEquipmentBookingProcessor
    {
        private readonly ILogger<EquipmentBookingProcessor> _logger;

        public EquipmentBookingProcessor(ILogger<EquipmentBookingProcessor> logger)
        {
            this._logger = logger;
        }

        public async Task<IEnumerable<Equipment>> GetEquipment(int Id)
        {
            return GetAllEquipment().Where(q => q.Id.Equals(Id));
        }

        public async Task<IEnumerable<Equipment>> GetEquipment()
        {
            return GetAllEquipment();
        }

        public async Task<IEnumerable<Equipment>> GetEquipmentByCategory(string category)
        {
            _logger.LogInformation("Returning all Equipment with category {category}", category);
            return GetAllEquipment().Where(q => q.Category.Equals(category));
        }

        private IEnumerable<Equipment> GetAllEquipment()
        {
            return new List<Equipment>
            {
                new Equipment { Id = 1, Name = "Hammer", Category = "tools", Price = 69.99,
                    Description = "Secure loose objects with minimal effort. " },
                new Equipment { Id = 2, Name = "Wrench", Category = "tools", Price = 49.99,
                    Description = "Tighten loose nuts and bolts. " },
                new Equipment { Id = 3, Name = "Pulley", Category = "tools", Price = 64.99,
                    Description = "Lift any item, no matter how heavy. "},
                new Equipment { Id = 4, Name = "Pliers", Category = "tools", Price = 79.99,
                    Description = "Tighten any screw professionaly. " },
            };
        }
    }
}
