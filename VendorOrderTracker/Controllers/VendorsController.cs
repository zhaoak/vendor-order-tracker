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
    Dictionary<string, object> model = new Dictionary<string, object>();
    Vendor foundVendor = Vendor.Find(id);
    List<Order> foundVendorOrders = foundVendor.VendorOrders;
    model.Add("vendor", foundVendor);
    model.Add("orders", foundVendorOrders);
    return View(model);
  }

  // order form submission route
  [HttpPost("/vendors/{vendorId}/orders")]
  public ActionResult Create(
      int vendorId,
      string orderTitle,
      string orderDescription,
      string orderItem,
      int orderQuantity,
      int orderPriceDollars,
      int orderPriceCents)
  {
    Dictionary<string, object> model = new Dictionary<string, object>();
    Vendor foundVendor = Vendor.Find(vendorId);
    Order newOrder = new Order(orderTitle, orderDescription, orderItem, orderQuantity, orderPriceDollars, orderPriceCents);
    foundVendor.VendorOrders.Add(newOrder);
    List<Order> foundVendorOrders = foundVendor.VendorOrders;
    model.Add("orders", foundVendorOrders);
    model.Add("vendor", foundVendor);
    return View("Show", model);
  }
}
