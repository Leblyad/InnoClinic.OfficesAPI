using InnoCLinic.OfficesAPI.Core.Entities.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoCLinic.OfficesAPI.Core.Contracts.Repositories
{
    public interface IOfficeRepository
    {
        Task UpdateServiceAsync(Office office);
        Task CreateOfficeAsync(Office office);
        Task DeleteOfficeAsync(Office office);
        Task<List<Office>> GetAllOfficesAsync();
        Task<Office> GetOfficeAsync(ObjectId officeId);
    }
}
