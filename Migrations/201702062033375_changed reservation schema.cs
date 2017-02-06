namespace EcoHostelAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedreservationschema : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "guestCount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservations", "guestCount");
        }
    }
}
