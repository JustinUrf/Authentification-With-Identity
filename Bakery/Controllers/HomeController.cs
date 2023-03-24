using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Controllers
{
  public class HomeController: Controller
  {
    private readonly BakeryContext _db;

    public HomeController(BakeryContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      Flavor theseFlavors = _db.Flavors.ToArray();
      Treat theseTreats = _db.Treats.ToArray();
      model.Add("flavors", theseFlavors);
      model.Add("treats", theseTreats);
      return View(model);
    }
  }
}