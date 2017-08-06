using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.DAL.Infrastrucrure;
using TaskManager.Management.Account;
using TaskManager.Middleware.Data.Api.Account;
using TaskManager.Middleware.Data.DataClasses;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager m = new UserManager(new EFUnitOfWork(new TaskManager.DAL.EF.DataContext(
                "DBConnection")));
            User u = m.Login(new LoginRequest() { Name="Bob",Password="123456"});
            Console.WriteLine(u.Name);
            Console.ReadLine();
        }
    }
}
