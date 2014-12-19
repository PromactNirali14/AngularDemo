using CrowdFunding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrowdFunding.DAL
{
    public class ProjextInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<ProjectContext>
    {
    
         protected override void Seed(ProjectContext context)
        {
            var Activity = new List<Activity>
            {
                new Activity{Name="ABC"},
                 new Activity{Name="Axd"},

            };

          Activity.ForEach ( s => context.Activity.Add(s));
        
           context.SaveChanges();
        }


       
    }
}