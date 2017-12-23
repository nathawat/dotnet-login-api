using System;
using System.Linq;

using api.Interfaces;
using api.Models;


namespace api.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly AppDbContext dbContext;

        public AuthenticationService(AppDbContext dbContext){
            this.dbContext = dbContext;
        }
        public User AttempLogin(string user, string password)
        {
            return this.dbContext.Users.Where(u => u.Username == user && u.Password == password).FirstOrDefault();
        }
    }
}