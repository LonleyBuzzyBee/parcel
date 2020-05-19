using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shipment.Models;
using System.Collections.Generic;
using System;

namespace Shipment.Test 
{
  [TestClass]
  public class ParcelTests
  {
    [TestMethod]
    public void ParcelConstructor_CreatesParcelInstance_Parcel()
    {
      Parcel newParcel = new Parcel(12, 12, 10, 10);
      Assert.AreEqual(typeof(Parcel), newParcel.GetType());
    }
  
    [TestMethod]
    public void GetVolume_VolumeReturnsVolume_Double()
    {
      Parcel newParcel = new Parcel(12, 12, 10, 10);
      double volume = newParcel.GetVolume();

      Assert.AreEqual(1440, volume);
    }
    [TestMethod]
    public void ParcelConstructor_GetCostToShip_ReturnsShippingCost()
    {
      Parcel newParcel = new Parcel(12, 12, 10, 10);
      double cost = newParcel.GetCostToShip();

      Assert.AreEqual(14.4, cost);
    }
  }
}