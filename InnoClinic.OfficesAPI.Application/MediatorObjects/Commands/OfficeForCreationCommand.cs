using InnoClinic.OfficesAPI.Application.DataTransferObjects;
using MediatR;

namespace InnoClinic.OfficesAPI.Application.MediatorObjects.Commands
{
    public class OfficeForCreationCommand : OfficeForManipulation, IRequest<OfficeDTO>
    {
    }
}
