using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.DAL.Interfaces;
using TaskManager.Management.Helpers;
using TaskManager.Management.Interfaces;
using TaskManager.Middleware.Data.Api.Account;
using TaskManager.Middleware.Data.DataClasses;

namespace TaskManager.Management.Account
{
    public class UserManager : BaseManager, IUserManager
    {
        public UserManager(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public User Register(CreateUserRequest req)
        {
            User user = UnitOfWork.UserRepository.Create(new User()
            {
                Name = req.Name,
                PasswordHash = SHA256Crypt.Hash(req.Password)
            });
            UnitOfWork.Save();
            return user;
        }
        public User Login(LoginRequest req)
        {
            return UnitOfWork.UserRepository.Find(
                x=>x.Name == req.Name
                && x.PasswordHash == SHA256Crypt.Hash(req.Password))
                .FirstOrDefault();
        }
    }
}
