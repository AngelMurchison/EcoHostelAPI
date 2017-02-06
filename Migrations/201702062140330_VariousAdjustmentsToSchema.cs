namespace EcoHostelAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VariousAdjustmentsToSchema : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "roomType", c => c.String());
            AddColumn("dbo.Rooms", "roomType", c => c.String());
            DropColumn("dbo.Reservations", "roomSize");
            DropColumn("dbo.Rooms", "Size");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rooms", "Size", c => c.String());
            AddColumn("dbo.Reservations", "roomSize", c => c.String());
            DropColumn("dbo.Rooms", "roomType");
            DropColumn("dbo.Reservations", "roomType");
        }
    }
}
