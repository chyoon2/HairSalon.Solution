using System.Collections.Generic;

namespace Salon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Client = new HashSet<Client>();
    }
    public int StylistId{get; set;}
    public string Name{get; set}
    public Date DateOfHire{get; set;}
    public virtual ICollection<Client> Client {get; set;}
  }
}