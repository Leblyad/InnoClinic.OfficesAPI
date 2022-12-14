using AutoMapper;
using InnoClinic.OfficesAPI.Application.DataTransferObjects;
using InnoCLinic.OfficesAPI.Core.Contracts.Repositories;
using MediatR;

namespace InnoClinic.OfficesAPI.Application.MediatorObjects.Queries
{
    public record GetAllOfficesHandler : IRequestHandler<GetAllOfficesQuery, List<OfficeDTO>>
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public GetAllOfficesHandler(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<List<OfficeDTO>> Handle(GetAllOfficesQuery request, CancellationToken cancellationToken)
        {
            var list = await _repositoryManager.Office.GetAllOfficesAsync();

            return _mapper.Map<List<OfficeDTO>>(list);
        }
    }
}
