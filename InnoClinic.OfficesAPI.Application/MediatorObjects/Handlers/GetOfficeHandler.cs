using AutoMapper;
using InnoClinic.OfficesAPI.Application.DataTransferObjects;
using InnoClinic.OfficesAPI.Application.MediatorObjects.Queries;
using InnoCLinic.OfficesAPI.Core.Contracts.Repositories;
using MediatR;
using MongoDB.Bson;

namespace InnoClinic.OfficesAPI.Application.MediatorObjects.Handlers
{
    public class GetOfficeHandler : IRequestHandler<GetOfficeQuery, OfficeDTO>
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public GetOfficeHandler(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<OfficeDTO> Handle(GetOfficeQuery request, CancellationToken cancellationToken)
        {
            var objectId = new ObjectId(request.officeId);
            var officeEntity = await _repositoryManager.Office.GetOfficeAsync(objectId);

            return _mapper.Map<OfficeDTO>(officeEntity);
        }
    }
}
