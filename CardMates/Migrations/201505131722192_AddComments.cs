namespace CardMates.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddComments : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CommentContexts",
                c => new
                    {
                        comment_ID = c.Int(nullable: false, identity: true),
                        comment_date = c.DateTime(nullable: false),
                        author = c.String(),
                        body = c.String(),
                    })
                .PrimaryKey(t => t.comment_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CommentContexts");
        }
    }
}
