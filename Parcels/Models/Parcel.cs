using System.Collections.Generic;

namespace Shipment.Models
{
  public class Parcel
  {
    public double Length { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }

    public double Volume { get; set; }
    public double Cost { get; set; }

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
      Volume = Length * Width * Height;
      return Volume;
    }
    public double GetCostToShip()
    {
      Cost = Length * Width * Height * Weight / 1000;
      return Cost;
    }
    public static List<Parcel> GetAll()
    {
      
      return _instances;
    }
    // public static List<Parcel> GetAll()
    // {
      
    //   return _instances;
    // }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}