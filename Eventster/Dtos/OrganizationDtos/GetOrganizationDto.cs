namespace Eventster.Dtos.OrganizationDtos
{
    public class GetOrganizationDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<OrganizationUser> Users { get; set; }
    }
}
