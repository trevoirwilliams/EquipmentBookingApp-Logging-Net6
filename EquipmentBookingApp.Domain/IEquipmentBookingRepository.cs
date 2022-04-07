using EquipmentBookingApp.Domain.Models;

namespace EquipmentBookingApp.Domain
{
    public interface IEquipmentBookingRepository
    {
        Task<IEnumerable<Equipment>> GetEquipmentByCategory(string category);
        Task<Equipment> GetEquipment(int Id);
        Task<IEnumerable<Equipment>> GetEquipment();
    }
}
