namespace CardMates.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newsID1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CommentContexts", "news_id", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CommentContexts", "news_id", c => c.String());
        }
    }
}
