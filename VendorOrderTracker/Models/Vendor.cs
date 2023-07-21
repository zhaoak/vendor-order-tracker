using System.Collections.Generic;

namespace VendorOrderTracker.Models;

public class Vendor
{
  private static List<Vendor> _instances = new List<Vendor> {};

  public string Name { get; }
  public string Description { get; set; }
  public int Id { get; } // Ids start from zero, not one
  public List<Order> VendorOrders { get; set; }

  // ==========================================================
  public Vendor(string vendorName, string vendorDescription)
  {
    Name = vendorName;
    Description = vendorDescription;
    _instances.Add(this);
    Id = _instances.Count - 1;  // -1 so Vendor Ids match their _instances index position
    VendorOrders = new List<Order>{};
  }

  public static void ClearAll() 
  {
    // there's a garbage collector, right?
    // this doesn't create a memory leak like in C++...right?
    _instances.Clear();
  }

  public static List<Vendor> GetAll()
  {
    return _instances;
  }
  
  public static Vendor Find(int id)
  {
    return _instances[id];
  }
}
