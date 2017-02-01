namespace EcoHostelAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserIDTypechange : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        phoneNumber = c.String(),
                        email = c.String(),
                        userName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Reservations", "userID", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Reservations", "userID");
            AddForeignKey("dbo.Reservations", "userID", "dbo.Users", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "userID", "dbo.Users");
            DropIndex("dbo.Reservations", new[] { "userID" });
            DropColumn("dbo.Reservations", "userID");
            DropTable("dbo.Users");
        }
    }
}
