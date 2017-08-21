namespace ToolsStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryMigration : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Brands ON");
            Sql("INSERT INTO Brands (BrandId, Name) VALUES (1,'DeWalt')");
            Sql("INSERT INTO Brands (BrandId, Name) VALUES (2, 'Makita')");
            Sql("INSERT INTO Brands (BrandId, Name) VALUES (3, 'Bosch')");
            Sql("INSERT INTO Brands (BrandId, Name) VALUES (4, 'Hitachy')");
            Sql("INSERT INTO Brands (BrandId, Name) VALUES (5, 'Delta')");
            Sql("INSERT INTO Brands (BrandId, Name) VALUES (6, 'Black&Decker')");
            Sql("INSERT INTO Brands (BrandId, Name) VALUES (7, 'Milwaukee')");
            Sql("INSERT INTO Brands (BrandId, Name) VALUES (8, 'Ryobi')");
            Sql("INSERT INTO Brands (BrandId, Name) VALUES (9, 'Panasonic')");
        }
        
        public override void Down()
        {
        }
    }
}
