using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Middleware.Data.Api.Workflow
{
    public class UpdateDomainTaskRequest
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
