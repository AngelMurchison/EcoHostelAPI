namespace EcoHostelAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adjustedschemas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "location", c => c.String());
            AddColumn("dbo.Reservations", "roomSize", c => c.String());
            AddColumn("dbo.Rooms", "Size", c => c.String());
            AddColumn("dbo.VolunteerTimes", "datetime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Rooms", "name");
            DropColumn("dbo.Rooms", "status");
            DropColumn("dbo.Rooms", "capacity");
            DropColumn("dbo.Rooms", "vacancy");
            DropColumn("dbo.VolunteerTimes", "date");
            DropColumn("dbo.VolunteerTimes", "time");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VolunteerTimes", "time", c => c.DateTime(nullable: false));
            AddColumn("dbo.VolunteerTimes", "date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Rooms", "vacancy", c => c.Int(nullable: false));
            AddColumn("dbo.Rooms", "capacity", c => c.Int(nullable: false));
            AddColumn("dbo.Rooms", "status", c => c.String(nullable: false));
            AddColumn("dbo.Rooms", "name", c => c.String(nullable: false));
            DropColumn("dbo.VolunteerTimes", "datetime");
            DropColumn("dbo.Rooms", "Size");
            DropColumn("dbo.Reservations", "roomSize");
            DropColumn("dbo.Events", "location");
        }
    }
}
