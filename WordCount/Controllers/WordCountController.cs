using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class WordCounterControlller : Controller
  {
    [HttpGet("/wordcounter/new")]
     public ActionResult Form()
     {

       return View();
       
     }     

     [HttpPost("/wordcounter")]
     public ActionResult Creat()
     {
       string targetWord = Request.Form["targetWord"];
       string sentence = Request.Form["sentence"];

       Word word = new Word(targetWord, sentence);

       int resultNumber = Word.GetAllNumbers();
       return View(resultNumber); 
     }
  }
}

