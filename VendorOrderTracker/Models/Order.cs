using System;

namespace VendorOrderTracker.Models;

public class Order
{
  public string Title;
  public string Description;
  public string Item;
  public DateTime EntryDate { get; }
  public int quantity { get; set; }
  private int priceDollars;
  private int priceCents;
  private bool _delivered = false;

  // =====================================

  public Order(string orderTitle, string orderDescription, string orderItem, int orderQuantity, int orderPriceDollars, int orderPriceCents)
  {
    Title = orderTitle;
    Description = orderDescription;
    Item = orderItem;
    EntryDate = TimeDate.Now();
    quantity = orderQuantity;
    priceDollars = orderPriceDollars;
    priceCents = orderPriceCents;
  }

  public bool CheckIfDelivered()
  {
    return _delivered;
  }

  public bool Delivered()
  {
    _delivered = true;
  }
  
}
