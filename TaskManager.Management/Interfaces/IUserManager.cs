using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Middleware.Data.Api.Account;
using TaskManager.Middleware.Data.DataClasses;

namespace TaskManager.Management.Interfaces
{
    public interface IUserManager
    {
        User Register(CreateUserRequest req);
        User Login(LoginRequest req);
    }
}
