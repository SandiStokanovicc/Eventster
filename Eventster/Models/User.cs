using Microsoft.AspNetCore.Identity;

namespace Eventster.Models
{
    public class User : IdentityUser
    {
        public List<OrganizationUser> OrganizationUsers { get; set; }
        //events
    }
}
