using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoClinic.OfficesAPI.Application.MediatorObjects.Commands
{
    public class OfficeForManipulation
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
