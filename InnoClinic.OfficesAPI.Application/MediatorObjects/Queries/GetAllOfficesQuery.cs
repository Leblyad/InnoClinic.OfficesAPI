using InnoClinic.OfficesAPI.Application.DataTransferObjects;
using MediatR;

namespace InnoClinic.OfficesAPI.Application.MediatorObjects.Queries
{
    public record GetAllOfficesQuery : IRequest<List<OfficeDTO>>;
}
