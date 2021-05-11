using System.Collections.Generic;

namespace Packages.Models
{
  public class Package
  {
    public float Length { get; set; }
    public float Width { get; set; }
    public float Height { get; set; }
    public float Weight { get; set; }

    public float TotalVolume { get; set; }
    private static List<Package> _instances = new List<Package> {};
    public Package(float length, float width, float height, float weight)
    {
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;
      TotalVolume = this.Volume(Length, Width, Height);

      _instances.Add(this);
    }
    public static List<Package> GetAll()
    {
      return _instances;
    }
    private float Volume(float length, float width, float height)
    {
      float totalVolume = length*width*height;
      return totalVolume;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}