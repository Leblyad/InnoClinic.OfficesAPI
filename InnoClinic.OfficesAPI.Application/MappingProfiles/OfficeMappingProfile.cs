using AutoMapper;
using InnoClinic.OfficesAPI.Application.DataTransferObjects;
using InnoClinic.OfficesAPI.Application.MediatorObjects.Commands;
using InnoCLinic.OfficesAPI.Core.Entities.Models;

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

            CreateMap<CreateOfficeCommand, Office>();

            CreateMap<UpdateOfficeCommand, Office>();
        }
    }
}
