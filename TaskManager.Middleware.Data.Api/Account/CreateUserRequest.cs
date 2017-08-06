using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Middleware.Data.Api.Account
{
    public class CreateUserRequest
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
    }
}
