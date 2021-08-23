using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Services.UserService
{
    interface IUserService
    {
        Task<List<User>> GetUsers();
        User GetUserByCredentials(string username);
        void RegisterUser(string username, string email, string password);
        //User GetUserByUrl(string url);
    }
}
