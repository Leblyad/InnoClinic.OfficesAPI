using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoClinic.OfficesAPI.Application.DataTransferObjects
{
    public class OfficeDTO
    {
        public string Id { get; set; }
        public string Address { get; set; }
        public string PhotoId { get; set; }
        public string Url { get; set; }
        public string RegistryPhoneNumber { get; set; }
        public string IsActive { get; set; }
    }
}
