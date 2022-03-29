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
        private readonly ILogger<EquipmentController> _logger;

        public EquipmentController(IEquipmentBookingProcessor equipmentBookProcessor, ILogger<EquipmentController> logger)
        {
            _equipmentBookProcessor = equipmentBookProcessor;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<Equipment>> Get(string category = "all")
        {
            _logger.LogInformation("API Request for equipment with category {category}", category);
            return await _equipmentBookProcessor.GetEquipmentByCategory(category);
        }
    }
}
