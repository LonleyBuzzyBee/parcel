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
  }
}