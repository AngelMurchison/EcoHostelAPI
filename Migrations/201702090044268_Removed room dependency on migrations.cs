namespace EcoHostelAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Removedroomdependencyonmigrations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reservations", "roomID", "dbo.Rooms");
            DropIndex("dbo.Reservations", new[] { "roomID" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Reservations", "roomID");
            AddForeignKey("dbo.Reservations", "roomID", "dbo.Rooms", "ID", cascadeDelete: true);
        }
    }
}
