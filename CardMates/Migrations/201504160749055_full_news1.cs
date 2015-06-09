namespace CardMates.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class full_news1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NewOnes", "news_full", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.NewOnes", "news_full");
        }
    }
}
