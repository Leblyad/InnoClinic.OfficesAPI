using AutoMapper;
using InnoClinic.OfficesAPI.Application.Services.Abstractions;
using InnoCLinic.OfficesAPI.Core.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
