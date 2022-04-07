using EquipmentBookingApp.Core;
using EquipmentBookingApp.Domain;
using EquipmentBookingApp.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace EquipmentBookingApp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EquipmentController : ControllerBase
    {
        private readonly IEquipmentBookingService _equipmentBookService;
        private readonly ILogger<EquipmentController> _logger;

        public EquipmentController(IEquipmentBookingService equipmentBookService, ILogger<EquipmentController> logger)
        {
            _equipmentBookService = equipmentBookService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<Equipment>> Get(string category = "all")
        {
            _logger.LogInformation("API Request for equipment with category {category}", category);
            return await _equipmentBookService.GetEquipmentByCategory(category);
        }
    }
}
