using System;
using api.Models;

namespace api.Interfaces
{
    public interface IAuthenticationService
    {
        User AttempLogin(String user, string password);
    }
}