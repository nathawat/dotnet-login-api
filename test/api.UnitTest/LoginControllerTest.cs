using System;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using Moq;
using api.Controllers;
using api.Interfaces;
using api.Models;

namespace api.UnitTest
{
    public class LoginControllerTest
    {
        private readonly LoginController loginController;

        [Fact]
        public void PostLogin_ResturnJSON_WhenLoginIsSuccessful(){

            var mockRepo = new Mock<IAuthenticationService>();
            mockRepo.Setup(repo => repo.AttempLogin(It.IsAny<string>(), It.IsAny<string>())).Returns(
                new User(){
                    Id = 1,
                    Username ="nathawat",
                    Displayname ="uooh"
                }
            );
            var loginController = new LoginController(mockRepo.Object);
            var result = loginController.Post(
                new User(){
                    Username ="nathawat",
                    Password ="1234"
                }
            );

            var viewResult = Assert.IsType<OkObjectResult>(result);
            var model = Assert.IsAssignableFrom<User>(viewResult.Value);
            Assert.Equal("nathawat", model.Username);
            Assert.Equal("uooh", model.Displayname);
        }
    }
}