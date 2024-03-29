using System;
using Microsoft.AspNetCore.Mvc;
using explosive.viewmodel;


namespace explosive.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ExplosionController : ControllerBase
  {
    [HttpGet("numbers/{s}")]
    public ActionResult<Model> Get(string s)
    {
      var newString = "";
      foreach (var c in s)
      {
        newString += new String(c, int.Parse(c.ToString()));
      }

      return new Model
      {
        GivenString = s,
        ModelResult = newString,
        Operation = "explosion"
      };
    }
  }


}