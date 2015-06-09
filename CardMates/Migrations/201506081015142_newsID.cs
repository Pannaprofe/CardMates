namespace CardMates.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newsID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CommentContexts", "news_id", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CommentContexts", "news_id");
        }
    }
}
