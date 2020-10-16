using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Factory.Controllers
{
  public class MachinesController : Controller
  {
    private readonly FactoryContext _db;
    public MachinesController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Machines.ToList());
    }
    public ActionResult Create()
    {
        ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "Name");
        return View();
    }
    [HttpPost]
    public ActionResult Create(Machine machine, int EngineerId)
    {
        _db.Machines.Add(machine);
        if (EngineerId != 0)
        {
          _db.EngineerMachine.Add(new EngineerMachine() { EngineerId = EngineerId, MachineId = machine.MachineId });
        }
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
        var thisMachine = _db.Machines
        .Include(machine => machine.Engineers)
        .ThenInclude(join => join.Engineer)
        .FirstOrDefault(machine => machine.MachineId == id);
        return View(thisMachine);
    }

    // public ActionResult Edit(int id)
    // {
    //     var thisMember = _db.Members.FirstOrDefault(members => members.MemberId == id);
    //     ViewBag.FarmId = new SelectList(_db.Farms, "FarmId", "Name");
    //     return View(thisMember);
    // }

    // [HttpPost]
    // public ActionResult Edit(Member member, int FarmId)
    // {
    //   if (FarmId != 0)
    //   {
    //     _db.FarmMember.Add(new FarmMember() { FarmId = FarmId, MemberId = member.MemberId });
    //   }
    //   _db.Entry(member).State = EntityState.Modified;
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    
    // public ActionResult Delete(int id)
    // {
    //   var thisItem = _db.Items.FirstOrDefault(items => items.ItemId == id);
    //   return View(thisItem);
    // }

    // [HttpPost, ActionName("Delete")]
    // public ActionResult DeleteConfirmed(int id)
    // {
    //   var thisItem = _db.Items.FirstOrDefault(items => items.ItemId == id);
    //   _db.Items.Remove(thisItem);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // [HttpPost]
    // public ActionResult DeleteCategory(int joinId)
    // {
    //     var joinEntry = _db.CategoryItem.FirstOrDefault(entry => entry.CategoryItemId == joinId);
    //     _db.CategoryItem.Remove(joinEntry);
    //     _db.SaveChanges();
    //     return RedirectToAction("Index");
    // }
  }
}