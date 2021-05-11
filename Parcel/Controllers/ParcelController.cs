using Microsoft.AspNetCore.Mvc;
using Packages.Models;
using System.Collections.Generic;

namespace Packages.Controllers
{
  public class PackageController : Controller
  {

    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      List<Package> allParcels = Package.GetAll();
      return View(allParcels);
    }

    [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult Create(float length, float width, float height, float weight)
    {
      Package myItem = new Package(length, width, height, weight);
      return RedirectToAction("Index");
    }

  }
}