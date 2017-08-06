using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using TaskManager.Helpers;
using TaskManager.Middleware.Data.DataClasses;
using TaskManager.Models;

namespace TaskManager.EF
{
    public class UserContext
    {
        public List<User> Users { get; set; }
        public List<Role> Roles { get; set; }

        public UserContext()
        {
            Users = new List<User>();
            Roles = new List<Role>();
            this.Roles.Add(new Role { Id = Guid.NewGuid(), Name = "admin" });
            this.Roles.Add(new Role { Id = Guid.NewGuid(), Name = "user" });
            this.Users.Add(new User
            {
                Id = Guid.NewGuid(),
                Name = "alice@gmail.com",
                PasswordHash = SHA256Crypt.Hash("123456"),
            });
            this.Users.Add(new User
            {
                Name = "tom@gmail.com",
                PasswordHash = "123456"
            });
        }
    }
}