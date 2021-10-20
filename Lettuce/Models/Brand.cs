using System;
using System.Collections.Generic;

namespace Lettuce.Models
{
  public class Brand
  {
    public Brand()
    {
      this.JoinEntities = new HashSet<BrandLettucePlant>();
    }

    public int BrandId { get; set; }
    public string Name { get; set; }

    public virtual ICollection <BrandLettucePlant> JoinEntities { get; set; }
  }
}