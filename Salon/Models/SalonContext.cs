using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Salon.Models
{
  public class Salon : DbContext
  {
    public virtual DbSet<Stylist> Stylists {get; set;}
    puclic virtual DbSet<Client> Clients {get; set;}
    public SalonContext(DbContextOptions options) : base(options) {}
  }
}