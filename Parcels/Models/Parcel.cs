using System.Collections.Generic;

namespace Shipment.Models
{
  public class Parcel
  {
    public double Length { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }
    public Parcel(double length, double width, double height, double weight)
    {
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;
    }
    public double Volume()
    {
      return Length * Width * Height;
    }
    public double CostToShip()
    {
      double cost = Length * Width * Height * Weight / 100;
      return cost;
    }

  }
}

// Volume, Cost to ship