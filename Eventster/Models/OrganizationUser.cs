namespace Eventster.Models
{
    public class OrganizationUser
    {
        public int Id { get; set; }
        public User User { get; set; }
        public int idUser { get; set; }
        public Organization Organization { get; set; }
        public int OrganizationId { get; set; }
        public OrganizationRole Role { get; set; } = OrganizationRole.Applied;
    }
}
