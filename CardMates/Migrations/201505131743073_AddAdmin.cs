namespace CardMates.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdmin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfile", "IsAdmin", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserProfile", "IsAdmin");
        }
    }
}
