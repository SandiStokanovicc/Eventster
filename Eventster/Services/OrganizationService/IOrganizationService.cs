using Eventster.Dtos.OrganizationDtos;

namespace Eventster.Services.OrganizationService
{
    public interface IOrganizationService
    {
        Task<ServiceResponse<List<GetOrganizationDto>>> CreateOrganization(AddOrganizationDto newOrg);
        Task<ServiceResponse<GetOrganizationDto>> GetOrganizationById(int id);
        Task<ServiceResponse<List<GetOrganizationDto>>> GetOrganizations();
    }
}
