using InnoCLinic.OfficesAPI.Core.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoCLinic.OfficesAPI.Core.Contracts
{
    public interface IRepositoryManager
    {
        IOfficeRepository Office { get; }
        Task SaveAsync();
    }
}
