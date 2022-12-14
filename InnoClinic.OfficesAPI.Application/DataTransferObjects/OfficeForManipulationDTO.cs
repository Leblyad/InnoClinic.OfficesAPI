using System.ComponentModel.DataAnnotations;

namespace InnoClinic.OfficesAPI.Application.DataTransferObjects
{
    public abstract class OfficeForManipulationDTO
    {
        [Required]
        public string City { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string HouseNumber { get; set; }
        public string OfficeNumber { get; set; }
        public Guid PhotoId { get; set; }
        [Required]
        public string RegistryPhoneNumber { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
