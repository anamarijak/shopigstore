namespace shoppingstore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "ItemArtUrl", c => c.String(maxLength: 1024));
            AlterColumn("dbo.Items", "Title", c => c.String(nullable: false, maxLength: 160));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Items", "Title", c => c.String());
            DropColumn("dbo.Items", "ItemArtUrl");
        }
    }
}
