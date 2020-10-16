using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace Factory.Controllers
{
  public class CompanysController : Controller
  {
  private readonly FactoryContext _db;

    public CompanysController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Engineer> model = _db.Engineers.ToList();
      return View(model);
    }
  }
}

//  var thisData = _db.Engineers
//       .Include(engineers => engineers.Machines)
//       .ThenInclude(join => join.Machine)
//       .FirstOrDefault(engineer => engineer.EngineerId == id);
//       return View(thisData);

