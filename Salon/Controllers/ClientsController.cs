using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Salon.Models;
using System.Linq;
using System;

namespace Salon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly SalonContext _db;

    public ClientsController(SalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Client> model = _db.Clients.Include(Clients => Clients.Stylist).ToList();
      return View(model);
    }

    public ActionResult Show(int id)
    {
      Client thisClient = _db.Clients.Include(Clients => Clients.Stylist).FirstOrDefault(Clients => Clients.ClientId == id);
      return View(thisClient);
    }
    
  }
}
