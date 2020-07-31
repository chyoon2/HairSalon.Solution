using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Salon.Models;
using System.Linq;

namespace Salon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly Salon _db;
    public ClientsController(SalonContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Client> model = _db.Clients.Include(Clients => Clients.Stylist).ToList();
      return View(model);
    }
  }
}