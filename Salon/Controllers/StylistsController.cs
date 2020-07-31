using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Salon.Models;
using System.Linq;
using System;

namespace Salon.Models
{
  public class StylistsController : Controller
  {
    private readonly SalonContext _db;
    
    public StylistsController(SalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Stylist> model = _db.Stylists.ToList();
      return View(model);
    }

    public ActionResult Show(int id)
    {
      Stylist thisStylist = _db.Stylists.Include(Stylists => Stylists.Clients).FirstOrDefault(Stylists => Stylists.StylistId == id);
      return View(thisStylist);
    }
  }
}