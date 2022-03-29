using EquipmentBookingApp.Domain;
using EquipmentBookingApp.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace EquipmentBookingApp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EquipmentController : ControllerBase
    {
        private readonly IEquipmentBookingProcessor _equipmentBookProcessor;

        public EquipmentController(IEquipmentBookingProcessor equipmentBookProcessor)
        {
            _equipmentBookProcessor = equipmentBookProcessor;
        }

        [HttpGet]
        public async Task<IEnumerable<Equipment>> Get(string category = "all")
        {
            return await _equipmentBookProcessor.GetEquipmentByCategory(category);
        }
    }
}
