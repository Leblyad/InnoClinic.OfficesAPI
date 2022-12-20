using System.ComponentModel.DataAnnotations;

namespace InnoClinic.OfficesAPI.Application.DataTransferObjects
{
    public class OfficeDTO
    {
        public string Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string OfficeNumber { get; set; }
        public Guid PhotoId { get; set; }
        public string RegistryPhoneNumber { get; set; }
        public bool Status { get; set; }
    }
}
