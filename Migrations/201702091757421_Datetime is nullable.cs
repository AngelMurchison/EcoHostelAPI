namespace EcoHostelAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Datetimeisnullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reservations", "startDate", c => c.DateTime());
            AlterColumn("dbo.Reservations", "endDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reservations", "endDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Reservations", "startDate", c => c.DateTime(nullable: false));
        }
    }
}
