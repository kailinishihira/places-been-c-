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
    private int _id;

    private static List<Place> _places = new List<Place> {};

    public Place (string location, string year, string season, string favoriteAttraction, string comments)
    {
      _location = location;
      _year = year;
      _season = season;
      _favoriteAttraction = favoriteAttraction;
      _comments = comments;
      _places.Add(this); //this is the same as the Save()
      _id = _places.Count;
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

    public int GetID() {
      return _id;
    }

    public static List<Place> GetAll()
    {
      return _places;
    }

    // public void Save()
    // {
    //   _places.Add(this);
    // }

    public static void ClearAll()
    {
      _places.Clear();
    }

    public static Place Find(int searchID)
    {
      return _places[searchID - 1];
    }
  }
}
