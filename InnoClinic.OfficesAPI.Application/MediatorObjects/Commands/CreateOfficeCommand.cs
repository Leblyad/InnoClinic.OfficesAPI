using AutoMapper;
using InnoClinic.OfficesAPI.Application.DataTransferObjects;
using InnoCLinic.OfficesAPI.Core.Contracts.Repositories;
using InnoCLinic.OfficesAPI.Core.Entities.Models;
using InnoCLinic.OfficesAPI.Core.Exceptions.UserClassExceptions;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace InnoClinic.OfficesAPI.Application.MediatorObjects.Commands
{
    public class CreateOfficeCommand : IRequest<OfficeDTO>
    {
        [Required]
        public string City { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string HouseNumber { get; set; }
        public string OfficeNumber { get; set; }
        public Guid PhotoId { get; set; }
        [Required]
        public string RegistryPhoneNumber { get; set; }
        [Required]
        public bool Status { get; set; }

        public class CreateOfficeHandler : IRequestHandler<CreateOfficeCommand, OfficeDTO>
        {
            private readonly IRepositoryManager _repositoryManager;
            private readonly IMapper _mapper;

            public CreateOfficeHandler(IRepositoryManager repositoryManager, IMapper mapper)
            {
                _repositoryManager = repositoryManager;
                _mapper = mapper;
            }

            public async Task<OfficeDTO> Handle(CreateOfficeCommand request, CancellationToken cancellationToken)
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
}
