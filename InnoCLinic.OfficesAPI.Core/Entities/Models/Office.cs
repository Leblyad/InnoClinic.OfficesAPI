using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoCLinic.OfficesAPI.Core.Entities.Models
{
    public class Office
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public Guid PhotoId { get; set; }
        public string Url { get; set; }
        public string RegistryPhoneNumber { get; set; }
        public string IsActive { get; set; }
    }
}
