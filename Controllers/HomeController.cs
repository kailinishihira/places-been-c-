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

    [HttpPost("/addplace")]
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
  }
}
