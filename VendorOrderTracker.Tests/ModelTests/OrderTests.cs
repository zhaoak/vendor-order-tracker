using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests;

[TestClass]
public class OrderTests
{
  [TestMethod]
  public void Constructor_CorrectlyCreates_Order()
  {
    //Arrange
    int testOrderQuantity = 5;
    int testOrderDollarPrice = 10;
    int testOrderCentPrice = 45;

    //Act
    Order testOrder = new Order("Test Order", "Test Description", "Test Item", testOrderQuantity, testOrderDollarPrice, testOrderCentPrice);
    // so long as these two lines execute within the same second,
    // the test will pass
    string testOrderEntryTime = (DateTime.Now).ToString();

    //Assert
    Assert.AreEqual(typeof(Order), testOrder.GetType());
    Assert.AreEqual(testOrder.Title, "Test Order");
    Assert.AreEqual(testOrder.Description, "Test Description");
    Assert.AreEqual(testOrder.Item, "Test Item");
    // EntryDate only needs to be second-accurate,
    // not millisecond-accurate
    Assert.AreEqual(testOrderEntryTime, testOrder.EntryDate.ToString());
    Assert.AreEqual(testOrderQuantity, testOrder.quantity);
    Assert.AreEqual(testOrderDollarPrice, testOrder.priceDollars);
    Assert.AreEqual(testOrderCentPrice, testOrder.priceCents);
    Assert.AreEqual(false, testOrder.CheckIfDelivered());
  }

  [TestMethod]
  public void Delivered_SetsDeliveredValue_True()
  {
    //Arrange
    int testOrderQuantity = 5;
    int testOrderDollarPrice = 10;
    int testOrderCentPrice = 45;

    //Act
    Order testOrder = new Order("Test Order", "Test Description", "Test Item", testOrderQuantity, testOrderDollarPrice, testOrderCentPrice);
    testOrder.Delivered();

    //Assert
    Assert.AreEqual(true, testOrder.CheckIfDelivered());
  }
}
