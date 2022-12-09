using InnoClinic.OfficesAPI.Application.DataTransferObjects;
using InnoCLinic.OfficesAPI.Core.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoClinic.OfficesAPI.Application.Services.Abstractions
{
    public interface IOfficeService
    {
        Task<List<OfficeDTO>> GetAllOfficeAsync();
        Task<OfficeDTO> GetOfficeAsync(string officeId);
        Task<OfficeDTO> CreateOfficeAsync(OfficeForCreationDTO office);
        Task UpdateOfficeAsync(string serviceId, OfficeForUpdateDTO office);
        Task DeleteOfficeAsync(string officeId);
    }
}
