using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Lettuce.Models;

namespace Lettuce.Controllers
{
  [Authorize]  
  public class LettucePlantsController:Controller
  {
    private readonly LettuceContext _db;
    private readonly UserManager <ApplicationUser> _userManager;

    public LettucePlantsController(LettuceContext db, UserManager<ApplicationUser> userManager)
    {
      _db = db;
      _userManager = userManager;
    }

    [AllowAnonymous]
    public ActionResult Index()
    {
      return View(_db.LettucePlants.ToList());
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Create(LettucePlant lettuce)
    {
        var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        var currentUser = await _userManager.FindByIdAsync(userId);
        lettuce.User = currentUser;
        _db.LettucePlants.Add(lettuce);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisLettuce = _db.LettucePlants
      .Include(lettucePlant => lettucePlant.UserLettucePlants)
      .ThenInclude(join => join.User)
      .FirstOrDefault(LettucePlant => LettucePlant.LettucePlantId == id);


      return View(thisLettuce);
    }
  }
}