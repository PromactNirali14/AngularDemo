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
        public DbSet<ActivityLog> ActivityLog { get; set; }
        public DbSet<AppSetting> AppSetting { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<Honour> Honour { get; set; }
        public DbSet<IMailMessages> IMailMessages { get; set; }
        public DbSet<IMailRecipients> IMailRecipients { get; set; }
        public DbSet<Interest> Interest { get; set; }
        public DbSet<InternalMailSystem> InternalMailSystem { get; set; }
        public DbSet<InviteUser> InviteUser { get; set; }
        public DbSet<Log> Log { get; set; }
        public DbSet<MasterHonour> MasterHonour { get; set; }
        public DbSet<MasterProjectInfo> MasterProjectInfo { get; set; }
        public DbSet<MasterProjectMilestone> MasterProjectMilestone { get; set; }
        public DbSet<MasterProjectPartners> MasterProjectPartners { get; set; }
        public DbSet<NewsletterSubscribe> NewslettetSubscribe { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<NotificationLog> NotificationLog { get; set; }
        public DbSet<Pledger> Pledger { get; set; }
        public DbSet<ProjectAccountDetails> ProjectAccountDetails { get; set; }
        public DbSet<ProjectComment> ProjectComment { get; set; }
        public DbSet<ProjectFollowers> ProjectFollowers { get;set;}
        public DbSet<ProjectInfo> ProjectInfo { get; set; }
        public DbSet<ProjectMilestone> ProjectMilestone { get; set; }
        public DbSet<ProjectPartners> ProjectPartners { get; set; }
        public DbSet<ProjectsOfTheWeek> ProjectsOfTheWeek { get; set; }
        public DbSet<ProjectStartRating> ProjectStartRating { get; set; }
        public DbSet<ProjectUpdates> ProjectUpdates { get; set; }
        public DbSet<ProjectUpdatesComments> ProjectUpdatesComments { get; set; }
        public DbSet<ReferenceFlowPoints> ReferenceFlowPoints { get; set; }
        public DbSet<ReportedProjectsToCF> ReportedProjectsToCF { get; set; }
        public DbSet<SocialMediaPostingInfo> SocialMediaPostingInfo { get; set; }
        public DbSet<SocialNetworkAccountInfo> SocialMediaAccountInfo { get; set; }
        public DbSet<SocialNetworkAuthenticationToken> SocialNetworkAuthenticationToken { get; set; }
        public DbSet<SocialNetworkInfo> SocialNetwrkInfo { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<SurveyAnswer> SurveyAnswer { get; set; }
        public DbSet<SurveyQuestion> SurveyQuestion { get; set; }
        public DbSet<Tags> Tags { get; set;}
        public DbSet<UserFollowers> UserFollowers { get; set; }
        public DbSet<UserIdentity> UserIdentity { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<UserToken> UserToken { get; set; }
        public DbSet<UserType> UserType { get; set; }
        public DbSet<UserWebSite> UserWebsite { get; set; }

 


        
        
    }

   
}