using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Linq;
using PierresSweetAndSavoryTreats.Models;

namespace PierresSweetAndSavoryTreats.Controllers
{
  public class HomeController: Controller
  {
    private readonly PierresSweetAndSavoryTreatsContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public HomeController(UserManager<ApplicationUser> userManager, PierresSweetAndSavoryTreatsContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    [HttpGet("/")]
    public async Task<ActionResult> Index()
    {
      return View();
    }

  }
}