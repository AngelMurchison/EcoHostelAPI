namespace EcoHostelAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SwitchingOverToWindowsPC : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "profilePictureURL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "profilePictureURL");
        }
    }
}
