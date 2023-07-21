using System;

namespace VendorOrderTracker.Models;

public class Order
{
  // most properties are public so they can be edited later if need be
  public string Title;
  public string Description;
  public string Item;
  public DateTime EntryDate { get; }
  public int quantity { get; set; }
  public int priceDollars;
  public int priceCents;
  private bool _delivered = false;

  // =====================================

  public Order(string orderTitle, string orderDescription, string orderItem, int orderQuantity, int orderPriceDollars, int orderPriceCents)
  {
    Title = orderTitle;
    Description = orderDescription;
    Item = orderItem;
    EntryDate = DateTime.Now;
    quantity = orderQuantity;
    priceDollars = orderPriceDollars;
    priceCents = orderPriceCents;
  }

  public bool CheckIfDelivered()
  {
    return _delivered;
  }

  public void Delivered()
  {
    _delivered = true;
  }
  
}
