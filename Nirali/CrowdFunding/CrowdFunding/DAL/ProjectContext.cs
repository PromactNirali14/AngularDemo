using CrowdFunding.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrowdFunding.DAL
{
    public class ProjectContext : DbContext
    {   /*Typically an Entity Framework application uses a class derived from DbContext. This derived class will call one of the constructors on the base DbContext class to control:

        How the context will connect to a database—i.e. how a connection string is found/used
        Whether the context will use calculate a model using Code First or load a model created with the EF Designer*/
        public ProjectContext() : base("ProjectContext") { } 
        //The name of the connection string (which  add to the Web.config file ) is passed in to the constructor

        public DbSet<Activity> Activity { get; set; }
        public DbSet<ActivityLog> ActivityLogs { get; set; }
        public DbSet<AppSetting> AppSettings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cities> Cities { get; set; }

        
    }

   
}