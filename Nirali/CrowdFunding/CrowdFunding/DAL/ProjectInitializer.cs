using CrowdFunding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrowdFunding.DAL
{
    public class ProjectInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<ProjectContext>
    {
    
         protected override void Seed(ProjectContext context)
        {

        
           context.SaveChanges();
        }


       
    }
}