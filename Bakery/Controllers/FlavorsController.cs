using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Bakery.Models;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

namespace Bakery.Controllers
{
  [Authorize]
  public class FlavorsController : Controller 
  {
    private readonly BakeryContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    public FlavorsController(BakeryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Flavors.ToList());
    }

    [Authorize]
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Flavor flavor)
    {
      if(!ModelState.IsValid)
      {
        return View(flavor);
      }
      else {
      _db.Flavors.Add(flavor);
      _db.SaveChanges();
      return RedirectToAction("Index");
      }

    }
  }
}