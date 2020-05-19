using System.Collections.Generic;

namespace Shipment.Models
{
  public class Parcel
  {
    public double Length { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }

    private static List<Parcel> _instances = new List<Parcel> {};
    public Parcel(double length, double width, double height, double weight)
    {
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;
      _instances.Add(this);
    }
    public double GetVolume()
    {
      return Length * Width * Height;
    }
    public double GetCostToShip()
    {
      double cost = Length * Width * Height * Weight / 1000;
      return cost;
    }
    public static List<Parcel> GetAll()
    {
      
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}