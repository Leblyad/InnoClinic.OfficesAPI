using InnoCLinic.OfficesAPI.Core.Contracts.Repositories;
using InnoCLinic.OfficesAPI.Core.Contracts.Settings;
using InnoCLinic.OfficesAPI.Core.Entities.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoClinic.OfficesAPI.Infrastructure.Repositories
{
    public class OfficeRepository : RepositoryBase<Office>, IOfficeRepository
    {
        public OfficeRepository(IOfficeStoreDatabaseSettings settings)
            : base(settings)
        {
        }

        public async Task CreateOfficeAsync(Office office)
        {
            await Create(office);
        }

        public async Task DeleteOfficeAsync(Office office)
        {
            await Delete(x => x.Id.Equals(office.Id));
        }

        public async Task<List<Office>> GetAllOfficesAsync()
        {
            return await FindByCondition(x => true);
        }

        public async Task<Office> GetOfficeAsync(ObjectId officeId)
        {
            var office = await FindByCondition(x => x.Id.Equals(officeId));
            return office.FirstOrDefault();
        }

        public async Task UpdateServiceAsync(Office office)
        {
            await Update(office);
        }
    }
}
