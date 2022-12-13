using InnoCLinic.OfficesAPI.Core.Contracts.Repositories;
using InnoCLinic.OfficesAPI.Core.Contracts.Settings;
using InnoCLinic.OfficesAPI.Core.Entities.Models;
using MongoDB.Bson;

namespace InnoClinic.OfficesAPI.Infrastructure.Repositories
{
    public class OfficeRepository : RepositoryBase<Office>, IOfficeRepository
    {
        public OfficeRepository(IOfficeStoreDatabaseSettings settings)
            : base(settings)
        {
        }

        public async Task CreateOfficeAsync(Office office) => await Create(office);

        public async Task DeleteOfficeAsync(Office office) => await Delete(x => x.Id.Equals(office.Id));

        public async Task<List<Office>> GetAllOfficesAsync() => await FindByCondition(x => true);

        public async Task<Office> GetOfficeAsync(ObjectId officeId) => (await FindByCondition(x => x.Id.Equals(officeId))).FirstOrDefault();

        public async Task UpdateOfficeAsync(Office office) => await Update(office);
    }
}
