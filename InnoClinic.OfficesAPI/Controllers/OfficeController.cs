using InnoClinic.OfficesAPI.Application.DataTransferObjects;
using InnoClinic.OfficesAPI.Application.Services.Abstractions;
using InnoCLinic.OfficesAPI.Core.Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace InnoClinic.OfficesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficeController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public OfficeController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOffice([FromBody] OfficeForCreationDTO office)
        {
            var officeDto = await _serviceManager.OfficeService.CreateOfficeAsync(office);

            return CreatedAtAction(nameof(GetOfficeById), new { officeId = officeDto.Id }, officeDto);
        }

        [HttpGet]

        public async Task<IActionResult> GetAllOffices()
        {
            var offices = await _serviceManager.OfficeService.GetAllOfficeAsync();

            return Ok(offices);
        }

        [HttpGet("{officeId}")]
        public async Task<IActionResult> GetOfficeById(string officeId)
        {
            var office = await _serviceManager.OfficeService.GetOfficeAsync(officeId);

            return Ok(office);
        }

        [HttpPut("{officeId}")]
        public async Task<IActionResult> UpdateOffice(string officeId, [FromBody] OfficeForUpdateDTO office)
        {
            await _serviceManager.OfficeService.UpdateOfficeAsync(officeId, office);

            return NoContent();
        }

        [HttpDelete("{officeId}")]
        public async Task<IActionResult> DeleteOffice(string officeId)
        {
            await _serviceManager.OfficeService.DeleteOfficeAsync(officeId);

            return NoContent();
        }
    }
}
