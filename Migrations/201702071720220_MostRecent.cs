namespace EcoHostelAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MostRecent : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reservations", "userID", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reservations", "userID", c => c.String(nullable: false));
        }
    }
}
