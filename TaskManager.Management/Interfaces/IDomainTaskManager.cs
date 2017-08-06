using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Middleware.Data.Api.Workflow;
using TaskManager.Middleware.Data.DataClasses;

namespace TaskManager.Management.Interfaces
{
    public interface IDomainTaskManager
    {
        DomainTask Create(CreateDomainTaskRequest req);
        void Remove(Guid id);
        void RemoveAll(Guid id);
        void Update(UpdateDomainTaskRequest req);
        IEnumerable<DomainTask> GetAll(Guid id);
    }
}
