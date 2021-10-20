namespace Lettuce.Models
{
  public class UserLettucePlant
  {
    public int UserLettucePlantId { get;set;}
    public int LettucePlantId { get;set;}

    public string UserId {get;set;}

    public virtual ApplicationUser User {get;set;}
    public virtual LettucePlant LettucePlant {get;set;}
  }
}