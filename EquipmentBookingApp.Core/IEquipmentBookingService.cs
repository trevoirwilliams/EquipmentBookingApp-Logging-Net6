using EquipmentBookingApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentBookingApp.Core
{
    public interface IEquipmentBookingService
    {
        Task<IEnumerable<Equipment>> GetEquipmentByCategory(string category);
        Task<Equipment> GetEquipment(int Id);
        Task<IEnumerable<Equipment>> GetEquipment();
    }
}
