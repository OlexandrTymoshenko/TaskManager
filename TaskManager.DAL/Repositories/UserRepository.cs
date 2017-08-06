using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.DAL.EF;
using TaskManager.DAL.Infrastrucrure;
using TaskManager.DAL.Interfaces;
using TaskManager.DAL.Interfaces.Repositories;
using TaskManager.Middleware.Data.DataClasses;

namespace TaskManager.DAL.Repositories
{
    public class UserRepository : Repository<User>, IRepository<User>,IUserRepository
    {
        public UserRepository(DataContext context) : base(context)
        {
        }
    }
}
