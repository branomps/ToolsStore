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
                    CategoryId = 4,
                    Title = "Makita DKP180Z",
                    Price = 179.99M,
                    ProductImgUrl = "~/Images/Makita/Makita DKP180Z.jpg",
                    Description = "It is plain to see why the Makita DKP180Z 18V Lithium-ion cordless planer is ideal for site and workshop alike. Developed with the same advantages of the KP0800 mains planer, the DKP180Z planer provides a no load speed of 14000rpm, delivering an 82mm planning width, 2mm maximum planning depth per pass and impressive rebate depth of 9mm. It us equipped with a simple to use."
                },
                new Product
                {
                    ProductId =2,
                    BrandId = 1,
                    CategoryId = 1,
                    Title = "Dewalt DCD740",
                    Price = 119.99M,
                    ProductImgUrl = "~/Images/Dewalt/",
                    Description = "The Dewalt DCD740N is part of the Dewalt XR Lithium-ion cordless range which offers eXtreme run time, increased efficiency and improved performance. By constantly monitoring tool and battery operation the intelligent switch module maximises performance and prevents damage caused by overload or temperature build - up This technology combined with a tough outer casing "
                },
                new Product
                {
                    ProductId = 3,
                    BrandId = 3,
                    CategoryId = 2,
                    Title = "Panasonic EY74A2LJ3G31R2",
                    Price = 227.99M,
                    ProductImgUrl = "~/Images/Panasonic/",
                    Description = "Panasonic EY74A2LJ3G31R2 14.4v & 18v Brushless Drill Driver is supplied with 2 x 5.0Ah Li-ion Batteries, 80 min Charger & Case. This Brushless Drill Driver offers a compact body at just 178mm with a lighter, yet more powerful motor compared to the brushed equlivant.Having a brushless motor means that none of the energy generated by the battery is wasted on friction and heat from carbon brushes.Instead all of that energy goes into the job you're doing which means that it is more efficient, concentrated and runtimes are increased."
                },
                new Product
                {
                    ProductId = 5,
                    BrandId = 5,
                    CategoryId = 5,
                    Title = "Hitachi CJ18DSL/L4",
                    Price = 113.99M,
                    ProductImgUrl = "~/Images/Hitachi/",
                    Description = "Hitachi CJ18DSL/L4 jigsaw with its ergonomically designed handle and weight of only 2.4kg it is both easy and comfortable to use and light enough to reduce user fatigue, keeping you going longer on the job. "
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