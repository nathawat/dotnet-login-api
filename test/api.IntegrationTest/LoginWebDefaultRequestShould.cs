using System;
using Xunit;

using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;

using System.Text;
using Newtonsoft.Json;

using api.Models;

namespace api.IntegrationTest
{
    public class LoginWebDefaultRequestShould
    {
        private readonly TestServer server;
        private readonly HttpClient client;

        public LoginWebDefaultRequestShould(){
            // Arrange
            server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            client = server.CreateClient();
        }

        [Fact]
        public async void ReturnUserInfoGivenLoginInfo()
        {
            var request = "/api/login";
            String jsonData = "{ \"username\": \"nathawat\", \"password\": \"1234\"}";
            HttpContent payload = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(request, payload);
            response.EnsureSuccessStatusCode();

            User results = JsonConvert.DeserializeObject<User>(await response.Content.ReadAsStringAsync());
            
            Assert.Equal("nathawat", results.Username);
            Assert.Equal("uooh", results.Displayname);
        }
    }
}