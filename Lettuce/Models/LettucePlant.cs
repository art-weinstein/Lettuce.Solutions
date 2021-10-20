using System;
using System.Collections.Generic;

namespace Lettuce.Models
{
  public class LettucePlant
  {
    
    public int LettucePlantId { get; set; }
    public string Name { get; set; }
    public virtual ApplicationUser User {get;set;}

    public virtual ICollection <BrandLettucePlant> JoinEntities { get; set; }

    public LettucePlant()
    {
      this.JoinEntities = new HashSet<BrandLettucePlant>();
    }
  }
}