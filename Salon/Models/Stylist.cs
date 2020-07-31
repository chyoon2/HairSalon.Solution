using System.Collections.Generic;
using System;

namespace Salon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Client = new HashSet<Client>();
    }
    public int StylistId{get; set;}
    public string Name{get; set;}
    public DateTime DateOfHire{get; set;}
    public virtual ICollection<Client> Client {get; set;}
  }
}