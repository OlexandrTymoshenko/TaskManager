using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Middleware.Data.DataClasses;

namespace TaskManager.DAL.EF
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<DomainTask> Tasks { get; set; }

        static DataContext()
        {
            Database.SetInitializer<DataContext>(new DefaultDbInitializer());
        }
        public DataContext(string connectionString)
            : base(connectionString)
        {
        }
    }
}
