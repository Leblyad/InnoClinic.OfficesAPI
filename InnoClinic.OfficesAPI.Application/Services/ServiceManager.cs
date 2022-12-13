using AutoMapper;
using InnoClinic.OfficesAPI.Application.Services.Abstractions;
using InnoCLinic.OfficesAPI.Core.Contracts.Repositories;

namespace InnoClinic.OfficesAPI.Application.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IOfficeService> _lazyOfficeService;

        public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _lazyOfficeService = new Lazy<IOfficeService>(() => new OfficeService(repositoryManager, mapper));
        }

        public IOfficeService OfficeService => _lazyOfficeService.Value;

    }
}
