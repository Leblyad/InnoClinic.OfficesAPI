using InnoCLinic.OfficesAPI.Core.Contracts.Repositories;
using InnoCLinic.OfficesAPI.Core.Contracts.Settings;

namespace InnoClinic.OfficesAPI.Infrastructure.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private IOfficeRepository _officeRepository;
        private readonly IOfficeStoreDatabaseSettings _settings;

        public RepositoryManager(IOfficeStoreDatabaseSettings settings)
        {
            _settings = settings;
        }

        public IOfficeRepository Office
        {
            get
            {
                if (_officeRepository == null)
                    _officeRepository = new OfficeRepository(_settings);

                return _officeRepository;
            }
        }
    }
}
