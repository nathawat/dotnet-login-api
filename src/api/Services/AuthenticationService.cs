using api.Interfaces;
using api.Models;

namespace api.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public User AttempLogin(string user, string password)
        {
            User user_nathawat = new User{
                Id = 1,
                Username ="nathawat",
                Displayname ="uooh"
            };

            return user_nathawat;
        }
    }
}