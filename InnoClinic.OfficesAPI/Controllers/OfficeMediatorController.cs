using InnoClinic.OfficesAPI.Application.DataTransferObjects;
using InnoClinic.OfficesAPI.Application.MediatorObjects.Commands;
using InnoClinic.OfficesAPI.Application.MediatorObjects.Queries;
using InnoCLinic.OfficesAPI.Core.Entities.Enums;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace InnoClinic.OfficesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = nameof(UserRole.Receptionist))]
    public class OfficeMediatorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OfficeMediatorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOffices()
        {
            var officesList = await _mediator.Send(new GetAllOfficesQuery());

            return Ok(officesList);
        }

        [HttpGet("{officeId}")]
        public async Task<IActionResult> GetOfficeById(string officeId)
        {
            var officeDto = await _mediator.Send(new GetOfficeQuery(officeId));

            return Ok(officeDto);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOffice([FromBody] CreateOfficeCommand office)
        {
            var officeDto = await _mediator.Send(office);

            return CreatedAtAction(nameof(GetOfficeById), new { officeId = officeDto.Id }, officeDto);
        }

        [HttpPut("{officeId}")]
        public async Task<IActionResult> UpdateOffice(string officeId, [FromBody] UpdateOfficeCommand office)
        {
            office.Id = officeId;
            await _mediator.Send(office);

            return NoContent();
        }

        [HttpDelete("{officeId}")]
        public async Task<IActionResult> DeleteOffice(string officeId)
        {
            await _mediator.Send(new DeleteOfficeCommand(officeId));

            return NoContent();
        }
    }
}
