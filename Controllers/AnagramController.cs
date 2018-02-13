using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Anagram.Models;

namespace Anagram.Controllers
{
  public class AnagramController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/")]
    public ActionResult Display()
    {
      AnagramGenerator newAnagramGenerator = new AnagramGenerator();
      string wordToCompare = Request.Form["word-to-compare"];
      List<string> wordList = new List<string>(){Request.Form["word-one"], Request.Form["word-two"], Request.Form["word-three"], Request.Form["word-four"], Request.Form["word-five"]};
      List<string> matchingAnagrams = newAnagramGenerator.ReturnAnagramMatches(wordToCompare, wordList);
      return View(matchingAnagrams);
    }
  }
}
