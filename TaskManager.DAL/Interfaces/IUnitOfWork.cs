using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.DAL.Interfaces.Repositories;
using TaskManager.Middleware.Data.DataClasses;

namespace TaskManager.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
        IDomainTaskRepository DomainTaskRepository { get; }
        void Save();
    }
}
