using InnoClinic.OfficesAPI.Application.DataTransferObjects;
using MediatR;

namespace InnoClinic.OfficesAPI.Application.MediatorObjects.Commands
{
    public record OfficeForUpdateCommand(OfficeForUpdateDTO office, string officeId) : IRequest;
}
