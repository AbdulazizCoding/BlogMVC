using Microsoft.AspNetCore.Identity;

namespace MVCPortfolio.Entities;

public class AppUser : IdentityUser
{
    // public string?  { get; set; }
    public virtual ICollection<Post>? Posts { get; set; }
}