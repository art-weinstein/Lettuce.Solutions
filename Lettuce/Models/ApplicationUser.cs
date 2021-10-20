using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Lettuce.Models
{
  public class ApplicationUser : IdentityUser
  {
    public virtual ICollection <UserLettucePlant> UserLettucePlants {get;set;}
  }
}