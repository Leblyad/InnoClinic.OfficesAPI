using AutoMapper;
using InnoClinic.OfficesAPI.Application.DataTransferObjects;
using InnoCLinic.OfficesAPI.Core.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InnoClinic.OfficesAPI.Application.DataTransferObjects.OfficeForManipulationDTO;

namespace InnoClinic.OfficesAPI.Application.MappingProfiles
{
    public class OfficeMappingProfile : Profile
    {
        public OfficeMappingProfile()
        {
            CreateMap<OfficeForCreationDTO, Office>();

            CreateMap<Office, OfficeDTO>()
                .ForMember(x => x.Id, opt => opt.MapFrom(src => src.Id.ToString()));

            CreateMap<OfficeForUpdateDTO, Office>();
        }
    }
}
