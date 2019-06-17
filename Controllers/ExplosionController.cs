using System;
using Microsoft.AspNetCore.Mvc;


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

  [Route("api/[controller]")]
  [ApiController]
  public class MumblingController : ControllerBase
  {
    [HttpGet("words/{s}")]
    public ActionResult<Model> Get(string s)
    {
      var newString = "";
      for (var i = 0; i < s.Length; i++)
      {
        var c = s[i];
        newString += c.ToString().ToUpper() + new String(char.ToLower(c), (i)) + "-";
      }
      return new Model
      {
        GivenString = s,
        ModelResult = newString.TrimEnd('-'),
        Operation = "mumbling"
      };
    }
  }
}