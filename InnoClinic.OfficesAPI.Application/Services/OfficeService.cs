using AutoMapper;
using InnoClinic.OfficesAPI.Application.DataTransferObjects;
using InnoClinic.OfficesAPI.Application.Services.Abstractions;
using InnoCLinic.OfficesAPI.Core.Contracts.Repositories;
using InnoCLinic.OfficesAPI.Core.Entities.Models;
using InnoCLinic.OfficesAPI.Core.Exceptions.UserClassExceptions;
using MongoDB.Bson;

namespace InnoClinic.OfficesAPI.Application.Services
{
    public class OfficeService : IOfficeService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public OfficeService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<OfficeDTO> CreateOfficeAsync(OfficeForCreationDTO office)
        {
            if (office == null)
            {
                throw new OfficeNullReferenceException(typeof(OfficeForCreationDTO));
            }

            var officeEntity = _mapper.Map<Office>(office);

            await _repositoryManager.Office.CreateOfficeAsync(officeEntity);

            return _mapper.Map<OfficeDTO>(officeEntity);
        }

        public async Task DeleteOfficeAsync(string officeId)
        {
            var objectId = new ObjectId(officeId);
            var office = await _repositoryManager.Office.GetOfficeAsync(objectId);

            if (office == null)
            {
                throw new OfficeNotFoundException(objectId);
            }

            await _repositoryManager.Office.DeleteOfficeAsync(office);
        }

        public async Task<List<OfficeDTO>> GetAllOfficeAsync()
        {
            var list = await _repositoryManager.Office.GetAllOfficesAsync();

            return _mapper.Map<List<OfficeDTO>>(list);
        }

        public async Task<OfficeDTO> GetOfficeAsync(string officeId)
        {
            var objectId = new ObjectId(officeId);
            var office = await _repositoryManager.Office.GetOfficeAsync(objectId);

            if (office == null)
            {
                throw new OfficeNotFoundException(objectId);
            }

            return _mapper.Map<OfficeDTO>(office);
        }

        public async Task UpdateOfficeAsync(string serviceId, OfficeForUpdateDTO office)
        {
            var officeEntity = _mapper.Map<Office>(office);
            officeEntity.Id = new ObjectId(serviceId);

            await _repositoryManager.Office.UpdateOfficeAsync(officeEntity);
        }
    }
}
