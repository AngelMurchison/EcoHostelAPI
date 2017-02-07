namespace EcoHostelAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adjustedschema : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "description", c => c.String());
            DropColumn("dbo.VolunteerTimes", "description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VolunteerTimes", "description", c => c.String());
            DropColumn("dbo.Events", "description");
        }
    }
}
