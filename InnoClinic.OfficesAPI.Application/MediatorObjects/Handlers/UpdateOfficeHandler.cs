using AutoMapper;
using InnoClinic.OfficesAPI.Application.MediatorObjects.Commands;
using InnoCLinic.OfficesAPI.Core.Contracts.Repositories;
using InnoCLinic.OfficesAPI.Core.Entities.Models;
using MediatR;
using MongoDB.Bson;

namespace InnoClinic.OfficesAPI.Application.MediatorObjects.Handlers
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
            var officeEntity = _mapper.Map<Office>(request.office);
            officeEntity.Id = new ObjectId(request.officeId);

            await _repositoryManager.Office.UpdateOfficeAsync(officeEntity);

            return Unit.Value;
        }
    }
}
