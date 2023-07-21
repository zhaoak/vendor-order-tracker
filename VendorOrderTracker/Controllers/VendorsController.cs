using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers;

public class VendorsController : Controller
{
  // vendor list page
  [HttpGet("/vendors")]
  public ActionResult Index()
  {
    List<Vendor> vendorList = Vendor.GetAll();
    return View(vendorList);
  }

  // add vendor form page
  [HttpGet("/vendors/new")]
  public ActionResult New()
  {
    return View();
  }

  // vender form submission route
  [HttpPost("/vendors")]
  public ActionResult Create(string vendorName, string vendorDescription)
  {
    Vendor newVendor = new Vendor(vendorName, vendorDescription);
    return RedirectToAction("Index");
  }

  // detail page for individual vendors, lists vendor orders
  [HttpGet("/vendors/{id}")]
  public ActionResult Show(int id)
  {
    Vendor foundVendor = Vendor.Find(id);
    return View(foundVendor);
  }
}
