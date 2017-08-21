namespace ToolsStore.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ToolsStore.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ToolsStore.Models.ToolsStoreDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ToolsStore.Models.ToolsStoreDB context)
        {


            context.Products.AddOrUpdate(
                p => p.ProductId,
                new Product
                {
                    ProductId = 1,
                    BrandId = 2,
                    CategoryId= 4,
                    Title = "Makita DKP180Z",
                    Price = 179.99M,
                    ProductImgUrl= "~/Images/Makita"

                }
                );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
