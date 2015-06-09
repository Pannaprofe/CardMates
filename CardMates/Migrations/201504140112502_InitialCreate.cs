namespace CardMates.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NewOnes",
                c => new
                    {
                        news_ID = c.Int(nullable: false, identity: true),
                        news_name = c.String(),
                        news_start = c.String(),
                        news_date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.news_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NewOnes");
        }
    }
}
