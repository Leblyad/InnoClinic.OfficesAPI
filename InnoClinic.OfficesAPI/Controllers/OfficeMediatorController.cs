using InnoClinic.OfficesAPI.Application.DataTransferObjects;
using InnoClinic.OfficesAPI.Application.MediatorObjects.Commands;
using InnoClinic.OfficesAPI.Application.MediatorObjects.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace InnoClinic.OfficesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
        public async Task<IActionResult> CreateOffice([FromBody] OfficeForCreationDTO office)
        {
            var officeDto = await _mediator.Send(new OfficeForCreationCommand(office));

            return CreatedAtAction(nameof(GetOfficeById), new { officeId = officeDto.Id }, officeDto);
        }

        [HttpPut("{officeId}")]
        public async Task<IActionResult> UpdateOffice(string officeId, [FromBody] OfficeForUpdateDTO office)
        {
            await _mediator.Send(new OfficeForUpdateCommand(office, officeId));

            return NoContent();
        }

        [HttpDelete("{officeId}")]
        public async Task<IActionResult> DeleteOffice(string officeId)
        {
            await _mediator.Send(new OfficeForDeleteCommand(officeId));

            return NoContent();
        }
    }
}
