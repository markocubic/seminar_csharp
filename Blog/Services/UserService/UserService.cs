using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;
        public UserService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<User>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public User GetUserByCredentials(string username)
        {
            return _context.Users.SingleOrDefault(a => a.UserName.Equals(username));
        }

        public void RegisterUser(string username, string email, string password)
        {
            User user = new()
            {
                UserName = username,
                Email = email,
                Password = password
            };
            _context.Users.Add(user);
            _context.SaveChanges();     
        }
    }
}
