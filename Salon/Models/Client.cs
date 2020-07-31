using System.Collections.Generic;
using System;

namespace Salon.Models
{
  public class Client
  {
    public int ClientId {get; set;}
    public string Name {get; set;}
    public int Phone {get; set;}
    public DateTime MemberSince {get; set;}
    public virtual Stylist Stylist {get; set;}
    public int StylistId {get; set;}
  }
}