using InnoCLinic.OfficesAPI.Core.Contracts.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoCLinic.OfficesAPI.Core.Contracts.Repositories
{
    public interface IRepositoryManager
    {
        public IOfficeRepository Office { get; }
    }
}
