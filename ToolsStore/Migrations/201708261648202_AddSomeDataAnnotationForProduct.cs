namespace ToolsStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSomeDataAnnotationForProduct : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Title", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Products", "ProductImgUrl", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Description", c => c.String());
            AlterColumn("dbo.Products", "ProductImgUrl", c => c.String());
            AlterColumn("dbo.Products", "Title", c => c.String());
        }
    }
}
