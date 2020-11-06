using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Task_Management_Platform.Models
{
    public class AppData : DbContext
    {
            public AppData(): base ("DBConnectionString") 
            {
                Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppData, Task_Management_Platform.Migrations.Configuration>("DBConnectionString"));
            }
    }
}