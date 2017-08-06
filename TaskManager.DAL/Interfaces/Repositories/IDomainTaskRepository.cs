using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Middleware.Data.DataClasses;

namespace TaskManager.DAL.Interfaces.Repositories
{
    public interface IDomainTaskRepository : IRepository<DomainTask>
    {
        void DeleteAllTasks(Guid userId);
    }
}
