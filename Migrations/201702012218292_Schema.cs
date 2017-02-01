namespace EcoHostelAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Schema : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "roomID", c => c.Int(nullable: false));
            AddColumn("dbo.Reservations", "startDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Reservations", "endDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Rooms", "name", c => c.String(nullable: false));
            AddColumn("dbo.Rooms", "status", c => c.String(nullable: false));
            AddColumn("dbo.Rooms", "capacity", c => c.Int(nullable: false));
            AddColumn("dbo.Rooms", "vacancy", c => c.Int(nullable: false));
            CreateIndex("dbo.Reservations", "roomID");
            AddForeignKey("dbo.Reservations", "roomID", "dbo.Rooms", "ID", cascadeDelete: true);
            DropTable("dbo.Users");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            DropForeignKey("dbo.Reservations", "roomID", "dbo.Rooms");
            DropIndex("dbo.Reservations", new[] { "roomID" });
            DropColumn("dbo.Rooms", "vacancy");
            DropColumn("dbo.Rooms", "capacity");
            DropColumn("dbo.Rooms", "status");
            DropColumn("dbo.Rooms", "name");
            DropColumn("dbo.Reservations", "endDate");
            DropColumn("dbo.Reservations", "startDate");
            DropColumn("dbo.Reservations", "roomID");
        }
    }
}
