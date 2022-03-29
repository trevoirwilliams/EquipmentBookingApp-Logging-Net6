using EquipmentBookingApp.Domain.Models;

namespace EquipmentBookingApp.Domain
{
    public interface IEquipmentBookingProcessor
    {
        Task<IEnumerable<Equipment>> GetEquipmentByCategory(string category);
        Task<IEnumerable<Equipment>> GetEquipment(int Id);
        Task<IEnumerable<Equipment>> GetEquipment();
    }
}
