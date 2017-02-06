namespace EcoHostelAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedeventsclassesrulesandvolunteertimes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        description = c.String(),
                        datetime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        datetime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Rules",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.VolunteerTimes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        description = c.String(),
                        location = c.String(),
                        date = c.DateTime(nullable: false),
                        time = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.VolunteerTimes");
            DropTable("dbo.Rules");
            DropTable("dbo.Events");
            DropTable("dbo.Classes");
        }
    }
}
