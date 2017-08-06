using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Middleware.Data.Api.Workflow
{
    public class CreateDomainTaskRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
