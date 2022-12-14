using AutoMapper;
using InnoCLinic.OfficesAPI.Core.Contracts.Repositories;
using InnoCLinic.OfficesAPI.Core.Entities.Models;
using MediatR;
using MongoDB.Bson;

namespace InnoClinic.OfficesAPI.Application.MediatorObjects.Commands
{
    public class UpdateOfficeHandler : IRequestHandler<OfficeForUpdateCommand>
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public UpdateOfficeHandler(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(OfficeForUpdateCommand request, CancellationToken cancellationToken)
        {
            var officeEntity = _mapper.Map<Office>(request);
            officeEntity.Id = new ObjectId(request.GetId());

            await _repositoryManager.Office.UpdateOfficeAsync(officeEntity);

            return Unit.Value;
        }
    }
}
