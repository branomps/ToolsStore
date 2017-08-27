namespace ToolsStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDisplayNameForProductImgUrlAndRemoveSomeRequiredAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Description", c => c.String(nullable: false));
        }
    }
}
