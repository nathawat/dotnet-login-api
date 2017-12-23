using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using api.Models;

namespace api.Controllers
{   
    [Route("api/login")]
    public class LoginController : Controller
    {
        [HttpPost]
        public IActionResult Post([FromBody]string value)
        {
            var data = new Dictionary<string, string>();
            data.Add("id", "1");
            data.Add("name", "nathawat");
            data.Add("displayname", "uooh");

            User user = new User{
                Id = 1,
                Username ="nathawat",
                Displayname ="uooh"
            };

            return  new OkObjectResult(user);
        }
    }
}