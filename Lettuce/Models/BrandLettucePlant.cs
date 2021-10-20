using Lettuce.Models;
using System.Collections.Generic;
using System;

namespace Lettuce.Models
{
  public class BrandLettucePlant
  {
    public int BrandLettucePlantId {get;set;}
    public int BrandId {get;set;}
    public int LettuceId {get;set;}
    public virtual Brand Brand {get;set;}
    public virtual LettucePlant LettucePlant {get;set;}
  }
}