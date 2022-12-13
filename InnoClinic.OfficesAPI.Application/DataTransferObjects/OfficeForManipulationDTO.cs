namespace InnoClinic.OfficesAPI.Application.DataTransferObjects
{
    public abstract class OfficeForManipulationDTO
    {
        public string Address { get; set; }
        public string PhotoId { get; set; }
        public string Url { get; set; }
        public string RegistryPhoneNumber { get; set; }
        public string IsActive { get; set; }
    }
}
