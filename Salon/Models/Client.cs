using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salon.Models
{
  public class Client
  {
    public Int ClientId{get; set;}
    public string Name{get; set;}
    public int Phone{get; set;}
    public Date MemberSince{get; set;}
    public virtual Stylist Stylist {get; set;}
  }
}