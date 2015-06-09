namespace CardMates.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class img : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NewOnes", "img_src", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.NewOnes", "img_src");
        }
    }
}
