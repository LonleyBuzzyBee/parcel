using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Shipment.Models;

namespace Shipment.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet ("/parcel/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcel")]
    public ActionResult Create(double length, double width, double height, double weight)
    {
      Parcel newParcel = new Parcel(length, width, height,weight);
      return View("Index", newParcel);
    }

    [HttpGet("/shipments")]
    public ActionResult Shipments()
    {
      List<Parcel> allParcels = Parcel.GetAll();
      return View(allParcels);
    }

    [HttpPost("/shipments")]
    public ActionResult CreateShipments(double length, double width, double height, double weight)
    {
      // List<Parcel> _instance = new List<Parcel> {};
      // return View("Index", _instances.ToString());

      Parcel newParcel = new Parcel(length, width, height, weight);
      return RedirectToAction("Shipments");
    }
  }
}