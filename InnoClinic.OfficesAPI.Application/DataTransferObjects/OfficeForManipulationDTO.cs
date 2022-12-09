using InnoCLinic.OfficesAPI.Core.Contracts.Attributes;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

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
