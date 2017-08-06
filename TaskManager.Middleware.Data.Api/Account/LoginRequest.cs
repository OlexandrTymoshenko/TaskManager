using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Middleware.Data.Api.Account
{
    public class LoginRequest
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
