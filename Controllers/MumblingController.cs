using System;
using Microsoft.AspNetCore.Mvc;
using explosive.viewmodel;

namespace explosive.Controllers
{
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