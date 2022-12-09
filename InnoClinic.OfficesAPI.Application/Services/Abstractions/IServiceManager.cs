using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoClinic.OfficesAPI.Application.Services.Abstractions
{
    public interface IServiceManager
    {
        IOfficeService OfficeService { get; }
    }
}
