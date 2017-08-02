using System.Collections.Generic;

namespace PlacesBeen.Models
{
  public class Place
  {
    private string _location;
    private string _year;
    private string _season;
    private string _favoriteAttraction;
    private string _comments;




    private static List<Place> _instances = new List<Place> {};

    public Place (string location, string year, string season, string favoriteAttraction, string comments)
    {
      _location = location;
      _year = year;
      _season = season;
      _favoriteAttraction = favoriteAttraction;
      _comments = comments;
    }

    public void SetLocation(string newLocation)
    {
      _location = newLocation;
    }
    public string GetLocation()
    {
      return _location;
    }

    public void SetYear(string newYear)
    {
      _year = newYear;
    }
    public string GetYear()
    {
      return _year;
    }

    public void SetSeason(string newSeason)
    {
      _season = newSeason;
    }
    public string GetSeason()
    {
      return _season;
    }

    public void SetFavoriteAttraction(string newFavoriteAttraction)
    {
      _favoriteAttraction = newFavoriteAttraction;
    }
    public string GetFavoriteAttraction()
    {
      return _favoriteAttraction;
    }

    public void SetComments(string newComments)
    {
      _comments = newComments;
    }
    public string GetComments()
    {
      return _comments;
    }
    //   _description = description;
    // }
    //
    // public string GetDescription()
    // {
    //   return _description;
    // }
    //
    // public void SetDescription(string newDescription)
    // {
    //   _description = newDescription;
    // }
    //
    // public static List<string> GetAll()
    // {
    //   return _instances;
    // }
    //
    // public void Save()
    // {
    //   _instances.Add(_description);
    // }
    //
    // public static void ClearAll()
    // {
    //   _instances.Clear();
    }
  }
}
