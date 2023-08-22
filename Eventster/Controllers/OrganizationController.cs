using System.Data;
using AutoMapper;
using Eventster.Auth;
using Eventster.Dtos.OrganizationDtos;
using Eventster.Services.OrganizationService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Eventster.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrganizationController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IOrganizationService _orgService;

        public OrganizationController(IOrganizationService organizationService, IMapper mapper)
        {
            _orgService = organizationService;
            _mapper = mapper;
        }
    

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _orgService.GetOrganizations());
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            return Ok(await _orgService.GetOrganizationById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddOrganizationDto newOrg)
        {
            return Ok(await _orgService.CreateOrganization(newOrg));
        }



    }
}
