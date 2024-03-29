using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Test Name","Description of Vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test Name";
      Vendor newVendor = new Vendor("Test Name","Description of Vendor");
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Description of Vendor";
      Vendor newVendor = new Vendor("Test Name", description);
      string result = newVendor.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_ReturnsSetDescription_String()
    {
      string description = "Description of Vendor";
      Vendor newVendor = new Vendor("Test Name", description);
      newVendor.Description = description;
      string result = newVendor.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorInstances_List()
    {
      Vendor v1 = new Vendor("Test Name", "description1");
      Vendor v2 = new Vendor("Test Name", "description2");
      List<Vendor> newList = new List<Vendor> { v1, v2};
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);

    }

    [TestMethod]
    public void GetId_ReturnVendorId_Int()
    {
      Vendor newVendor = new Vendor("Test Name", "description of vendor");
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string vendor1 = "Vendor uno";
      string vendor2 = "Vendor dos";
      Vendor newVendor1 = new Vendor(vendor1, "test name");
      Vendor newVendor2 = new Vendor(vendor2, "vender dos");
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);  
    }
  }
}