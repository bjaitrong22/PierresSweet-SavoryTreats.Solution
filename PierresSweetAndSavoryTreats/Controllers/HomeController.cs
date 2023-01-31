using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using PierresSweetAndSavoryTreats.Models;

namespace PierresSweetAndSavoryTreats.Controllers
{
  public class HomeController: Controller
  {
    private readonly PierresSweetAndSavoryTreatsContext _db;
    
    public HomeController(PierresSweetAndSavoryTreatsContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      Treat[] treats = _db.Treats.ToArray();
      Flavor[]flavors = _db.Flavors.ToArray();

      Dictionary<string, object[]> model = new Dictionary<string, object[]>();

      model.Add("Treats", treats );
      model.Add("Flavors", flavors);

      return View(model);
    }

  }
}