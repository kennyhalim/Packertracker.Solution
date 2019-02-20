using System.Collections.Generic;

namespace Packertracker.Models
{
  public class Packer
  {
    private string _name;
    private string _manufacture;
    private int _price;
    private int _weight;
    private string _ispurchased;
    private string _ispacked;
    private static List<Packer> _myList = new List<Packer> {};
    private int _id;

    public Packer (string name, string manufacture, int price, int weight, string ispurchased, string ispacked)
    {
      _name = name;
      _manufacture = manufacture;
      _price = price;
      _weight = weight;
      _ispurchased = ispurchased;
      _ispacked = ispacked;
      _myList.Add(this);
      _id = _myList.Count;
    }

    public string GetName()
    {
      return _name;
    }

    public string GetManufacture()
    {
      return _manufacture;
    }

    public int GetPrice()
    {
      return _price;
    }

    public int GetWeight()
    {
      return _weight;
    }

    public string IsPacked()
    {
      if(_ispacked == "true"){
        return "Packed";
      }
      else {
        return "Not Packed";
      }
    }

    public string IsPurchased()
    {
      if(_ispurchased == "true"){
        return "Purchased";
      }
      else {
        return "Not Purchased";
      }
    }

    public static List<Packer> GetAll()
    {
      return _myList;
    }

    public static void ClearAll()
    {
      _myList.Clear();
    }

    public static Packer Find(int searchId)
    {
      return _myList[searchId-1];
    }

    public int GetId()
   {
     return _id;
   }
  }
}
