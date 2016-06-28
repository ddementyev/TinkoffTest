namespace TinkoffTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v100 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UrlsData",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        ShortUrl = c.String(unicode: false),
                        InitialUrl = c.String(unicode: false),
                        CreationDate = c.DateTime(),
                        Clicks = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UrlsData");
        }
    }
}
