using Microsoft.AspNetCore.Identity;

namespace QuintrixWeb.Models
{
    public class ApplicationUser : IdentityUser
    {
        internal string NormalizedName;

        public string City { get; set; }
        public string Name { get; internal set; }
    }
}
