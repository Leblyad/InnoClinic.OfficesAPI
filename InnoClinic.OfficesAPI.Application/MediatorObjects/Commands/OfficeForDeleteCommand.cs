using MediatR;

namespace InnoClinic.OfficesAPI.Application.MediatorObjects.Commands
{
    public record OfficeForDeleteCommand(string officeId) : IRequest;
}
