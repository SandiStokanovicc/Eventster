using AutoMapper;
using Eventster.Dtos.OrganizationDtos;

namespace Eventster
{
    public class AutoMapperProfile :Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Organization, GetOrganizationDto>();
            CreateMap<AddOrganizationDto, Organization>();
        }
    }
}
