namespace Eventster.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<OrganizationUser> Users { get; set; }

    }
}
