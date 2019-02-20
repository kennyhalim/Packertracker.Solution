using Microsoft.AspNetCore.Mvc;
using Packertracker.Models;
using System.Collections.Generic;

namespace Packertracker.Controllers
{
  public class PackertrackerController : Controller
  {

    [HttpGet("/packertracker")]
    public ActionResult Index()
    {
      List<Packer> allPackers = Packer.GetAll();
      return View(allPackers);
    }

    [HttpGet("/packertracker/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/packertracker")]
    public ActionResult Create(string name, string manufacture, int price, int weight, string ispurchased, string ispacked)
    {
        Packer myPacker = new Packer(name, manufacture, price, weight, ispurchased, ispacked);
        return RedirectToAction("Index");
    }

    [HttpGet("/packertracker/{id}")]
    public ActionResult Show(int id)
    {
      Packer packer = Packer.Find(id);
      return View(packer);
    }

    [HttpPost("/packertracker/delete")]
    public ActionResult DeleteAll()
    {
      Packer.ClearAll();
      return View();
    }

  }
}
