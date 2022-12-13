using InnoCLinic.OfficesAPI.Core.Entities.Models;
using MongoDB.Bson;

namespace InnoCLinic.OfficesAPI.Core.Contracts.Repositories
{
    public interface IOfficeRepository
    {
        Task UpdateOfficeAsync(Office office);
        Task CreateOfficeAsync(Office office);
        Task DeleteOfficeAsync(Office office);
        Task<List<Office>> GetAllOfficesAsync();
        Task<Office> GetOfficeAsync(ObjectId officeId);
    }
}
