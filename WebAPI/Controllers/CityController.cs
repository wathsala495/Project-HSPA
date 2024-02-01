using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
    
      public CityController()
      {

      }   
      [HttpGet("")]
      public IEnumerable<string> Getstrings()
      {
         return new string[] {"Atlanta","New York","Chicago","Bostan"};
      }
       [HttpGet("{id}")]
      public string Get(int id)
      {
         return "Atlanta";
      }
    }
}
