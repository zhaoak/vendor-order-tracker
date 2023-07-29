using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System;
using System.Collections.Generic;

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

  [TestMethod]
  public void GetAll_ReturnsAll_Vendors()
  {
    List<Vendor> testVendorList = new List<Vendor> ();

    Vendor testVendor1 = new Vendor("Shrek", "Ogre");
    Vendor testVendor2 = new Vendor("Donkey", "Donkey");
    testVendorList.Add(testVendor1);
    testVendorList.Add(testVendor2);

    CollectionAssert.AreEqual(testVendorList, Vendor.GetAll());
  }

  [TestMethod]
  public void Find_FindsCorrect_Vendor()
  {
    //Arrange
    Vendor testVendor1 = new Vendor("Shrek", "Ogre");
    Vendor testVendor2 = new Vendor("Donkey", "Donkey");
    Vendor testVendor3 = new Vendor("Fiona", "Ogre"); // will have ID of 2

    //Act
    Vendor foundVendor = Vendor.Find(2);
    
    //Assert
    Assert.AreEqual(testVendor3, foundVendor);
  }
}
