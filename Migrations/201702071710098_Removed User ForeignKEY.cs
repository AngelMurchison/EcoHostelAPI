namespace EcoHostelAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedUserForeignKEY : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reservations", "userID", "dbo.Users");
            DropIndex("dbo.Reservations", new[] { "userID" });
            AlterColumn("dbo.Reservations", "userID", c => c.String(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reservations", "userID", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Reservations", "userID");
            AddForeignKey("dbo.Reservations", "userID", "dbo.Users", "ID", cascadeDelete: true);
        }
    }
}
