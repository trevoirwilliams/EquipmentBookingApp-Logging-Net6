using EquipmentBookingApp.Domain;
using EquipmentBookingApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EquipmentBookingApp.Core
{
    public class EquipmentBookingService : IEquipmentBookingService
    {
        private readonly IEquipmentBookingRepository equipmentBookingRepository;

        public EquipmentBookingService(IEquipmentBookingRepository equipmentBookingRepository)
        {
            this.equipmentBookingRepository = equipmentBookingRepository;
        }

        public async Task<Equipment?> GetEquipment(int Id)
        {
            var equipment = await equipmentBookingRepository.GetEquipment(Id);
            if(equipment == null)
            {
                return null;
            }
            return equipment;
        }

        public async Task<IEnumerable<Equipment>> GetEquipment()
        {
            return await equipmentBookingRepository.GetEquipment();
        }

        public async Task<IEnumerable<Equipment>> GetEquipmentByCategory(string category)
        {
            if (category.Equals("all"))
            {
                return await equipmentBookingRepository.GetEquipment();
            }
            return await equipmentBookingRepository.GetEquipmentByCategory(category);
        }
    }
}
