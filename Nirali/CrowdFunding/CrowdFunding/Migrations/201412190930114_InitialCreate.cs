namespace CrowdFunding.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ActivityLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ActivityId = c.Int(nullable: false),
                        UserInfoId = c.Int(nullable: false),
                        ProjectId = c.Int(nullable: false),
                        ParnerId = c.Int(),
                        ProjectUpdateId = c.Int(),
                        TimeStamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Activities", t => t.ActivityId, cascadeDelete: true)
                .Index(t => t.ActivityId);
            
            CreateTable(
                "dbo.AppSettings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Key = c.String(nullable: false),
                        value = c.String(nullable: false),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false),
                        ParentcategoryId = c.Int(),
                        Status = c.Int(nullable: false),
                        CategoryImage = c.String(),
                        category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.category_Id)
                .Index(t => t.category_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "category_Id", "dbo.Categories");
            DropForeignKey("dbo.ActivityLogs", "ActivityId", "dbo.Activities");
            DropIndex("dbo.Categories", new[] { "category_Id" });
            DropIndex("dbo.ActivityLogs", new[] { "ActivityId" });
            DropTable("dbo.Categories");
            DropTable("dbo.AppSettings");
            DropTable("dbo.ActivityLogs");
            DropTable("dbo.Activities");
        }
    }
}
