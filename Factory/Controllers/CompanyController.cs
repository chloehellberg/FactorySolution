using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace Factory.Controllers
{
  public class CompanyController : Controller
  {
  private readonly FactoryContext _db;

    public CompanyController(FactoryContext db)
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