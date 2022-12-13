using InnoClinic.OfficesAPI.Application.DataTransferObjects;
using MediatR;

namespace InnoClinic.OfficesAPI.Application.MediatorObjects.Commands
{
    public record OfficeForCreationCommand(OfficeForCreationDTO office) : IRequest<OfficeDTO>;
}
