using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using api.Models;

using api.Interfaces;
using api.Services;

namespace api.Controllers
{   
    [Route("api/login")]
    public class LoginController : Controller
    {   
        private readonly IAuthenticationService authenticationService;
        public LoginController(IAuthenticationService authenticationService){
            this.authenticationService = authenticationService;
        }


        [HttpPost]
        public IActionResult Post([FromBody]User req)
        {
            User user = authenticationService.AttempLogin(req.Username, req.Password);
            return  new OkObjectResult(user);
        }
    }
}