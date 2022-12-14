using AutoMapper;
using InnoClinic.OfficesAPI.Application.DataTransferObjects;
using InnoCLinic.OfficesAPI.Core.Contracts.Repositories;
using InnoCLinic.OfficesAPI.Core.Entities.Models;
using InnoCLinic.OfficesAPI.Core.Exceptions.UserClassExceptions;
using MediatR;

namespace InnoClinic.OfficesAPI.Application.MediatorObjects.Commands
{
    public class CreateOfficeHandler : IRequestHandler<OfficeForCreationCommand, OfficeDTO>
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public CreateOfficeHandler(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<OfficeDTO> Handle(OfficeForCreationCommand request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                throw new OfficeNullReferenceException(typeof(OfficeForCreationDTO));
            }

            var officeEntity = _mapper.Map<Office>(request);

            await _repositoryManager.Office.CreateOfficeAsync(officeEntity);

            var officeDto = _mapper.Map<OfficeDTO>(officeEntity);

            return officeDto;
        }
    }
}
