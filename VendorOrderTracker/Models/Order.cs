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
  public int priceCents;  // unless fractional cent values are relevant, best to avoid floats
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

  public string PriceAsString()
  {
    string priceString = $"${priceDollars}.{priceCents}";
    if (priceCents < 10)
    {
      // adding extra zero to cent value if cent value is single digit
      // won't work if you're a weirdo not using base ten
      priceString = priceString.Insert((priceString.Length - 1), "0");
    }
    return priceString;
  }
  
}
