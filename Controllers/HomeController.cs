using Microsoft.AspNetCore.Mvc;
using PlacesBeen.Models;
using System.Collections.Generic;
using System;

namespace PlacesBeen.Contollers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/places/new")]
    public ActionResult NewPlaces()
    {
      return View();
    }

    [HttpPost("/places/add")]
    public ActionResult AddPlace()
    {
      string location = Request.Form["location"];
      string year = Request.Form["year"];
      string season = Request.Form["season"];
      string favoriteAttraction = Request.Form["favoriteAttraction"];
      string comments = Request.Form["comments"];

      Place newPlace = new Place(location, year, season, favoriteAttraction, comments);

      return View(newPlace);
    }

    [HttpGet("/places/all")]
    public ActionResult Places()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }

    [HttpGet("/places/{id}")]
    public ActionResult PlaceDetail(int id)
    {
      Place place = Place.Find(id);
      return View(place);
    }
  }
}
