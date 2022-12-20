using AutoMapper;
using InnoClinic.OfficesAPI.Application.DataTransferObjects;
using InnoCLinic.OfficesAPI.Core.Contracts.Repositories;
using InnoCLinic.OfficesAPI.Core.Entities.Models;
using MediatR;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace InnoClinic.OfficesAPI.Application.MediatorObjects.Commands
{
    public class UpdateOfficeCommand : IRequest
    {
        public string Id;
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

        public class UpdateOfficeHandler : IRequestHandler<UpdateOfficeCommand>
        {
            private readonly IRepositoryManager _repositoryManager;
            private readonly IMapper _mapper;

            public UpdateOfficeHandler(IRepositoryManager repositoryManager, IMapper mapper)
            {
                _repositoryManager = repositoryManager;
                _mapper = mapper;
            }

            public async Task<Unit> Handle(UpdateOfficeCommand request, CancellationToken cancellationToken)
            {
                var officeEntity = _mapper.Map<Office>(request);
                officeEntity.Id = new ObjectId(request.Id);

                await _repositoryManager.Office.UpdateOfficeAsync(officeEntity);

                return Unit.Value;
            }
        }
    }
}
