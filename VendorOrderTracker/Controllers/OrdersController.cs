using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers;

public class OrdersController : Controller
{
  // add order form page
  [HttpGet("/vendors/{vendorId}/orders/new")]
  public ActionResult New(int vendorId)
  {
    Vendor orderVendor = Vendor.Find(vendorId);
    return View(orderVendor);
  }
}
