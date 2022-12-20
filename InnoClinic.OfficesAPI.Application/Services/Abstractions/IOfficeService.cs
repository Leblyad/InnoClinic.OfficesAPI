using InnoClinic.OfficesAPI.Application.DataTransferObjects;

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
