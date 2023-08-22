using AutoMapper;
using Eventster.Data;
using Eventster.Dtos.OrganizationDtos;
using Microsoft.EntityFrameworkCore;

namespace Eventster.Services.OrganizationService
{
    public class OrganizationService : IOrganizationService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public OrganizationService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<ServiceResponse<GetOrganizationDto>> GetOrganizationById(int id)
        {
            var serviceResponse = new ServiceResponse<GetOrganizationDto>();

            var dbComponents = await _context.Organizations
                .Include(a => a.Users)
                .FirstOrDefaultAsync(a => a.Id == id);

            serviceResponse.Data = _mapper.Map<GetOrganizationDto>(dbComponents);

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetOrganizationDto>>> GetOrganizations()
        {
            var serviceResponse = new ServiceResponse<List<GetOrganizationDto>>();

            var dbComponents = await _context.Organizations
                .ToListAsync();
            serviceResponse.Data = dbComponents.Select(a => _mapper.Map<GetOrganizationDto>(a))
                .ToList();

            return serviceResponse;
        }


        public async Task<ServiceResponse<List<GetOrganizationDto>>> CreateOrganization(AddOrganizationDto newOrg)
        {
            var serviceResponse = new ServiceResponse<List<GetOrganizationDto>>();

            Organization newOrganization = _mapper.Map<Organization>(newOrg);
            _context.Organizations.Add(newOrganization);
            await _context.SaveChangesAsync();
            serviceResponse.Data = await _context.Organizations
                .Select(a => _mapper.Map<GetOrganizationDto>(a))
                .ToListAsync();

            return serviceResponse;
        }




    }
}
