using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests;

[TestClass]
public class VendorTests : IDisposable
{
  public void Dispose()
  {
    Vendor.ClearAll();
  }

  [TestMethod]
  public void Constructor_CorrectlyCreates_Vendor()
  {
    //Arrange
    string testVendorName = "vendy";
    string testVendorDescription = "vendy knows things";

    //Act
    Vendor testVendor = new Vendor(testVendorName, testVendorDescription);
    Vendor testVendor2 = new Vendor(testVendorName, testVendorDescription);

    //Assert
    Assert.AreEqual(testVendorName, testVendor.Name);
    Assert.AreEqual(testVendorDescription, testVendor.Description);
    Assert.AreEqual(testVendor.Id, 0);
    Assert.AreEqual(testVendor2.Id, 1);
  }
}
