using InnoCLinic.OfficesAPI.Core.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoCLinic.OfficesAPI.Core.Contracts.Repositories
{
    public interface IOfficeRepository
    {
        Task<IEnumerable<Office>> GetAllOfficesAsync();
        Task<Office> GetOfficeAsync(Guid officeId);
        Task CreateOfficeAsync(Office office);
        Task DeleteOfficeAsync(Office office);
    }
}
