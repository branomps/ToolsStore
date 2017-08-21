namespace ToolsStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategories : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Categories ON");
            Sql("INSERT INTO Categories (CategoryId, Name, Description) VALUES (1,'Angle Drill','A right Angle drill is not a tool you will find in most tool boxes, although many home handymen will sometimes wish they had one.')");
            Sql("INSERT INTO Categories (CategoryId, Name, Description) VALUES (2,'Drill Drivers','A Cordless drill/driver is a versatile tool that  is designed to drill holes and drive screws. Its keyless chuck accepts a wide variety of round- and hex-shank drill bits and screw-driving bits, as well as hole saws, rotary sanders, wire-wheel brushes, and other accessories.')");
            Sql("INSERT INTO Categories (CategoryId, Name, Description) VALUES (3,'Jigsaws','In summary, then, a Cordless jigsaw is ideal for getting the cut made quickly, independent of a wired power source and our choice of cordless jigsaw will likely be influenced by the cordless power tools we already own.')");
            Sql("INSERT INTO Categories (CategoryId, Name, Description) VALUES (4,'Planers','Cordless planer, giving freedom to move around the jobsite without the constraint of a power socket being required. With an easy to use adjustable depth settings with the large depth adjustment knob with click stops and easy to read scale with 0.1mm divisions.')");
            Sql("INSERT INTO Categories (CategoryId, Name, Description) VALUES (5,'Screwdrivers','Cordelss screwdriver increases user protection compared to power tools without the feature. The power tool will be switched off if suddenly rotating around the drilling axes.')");
            Sql("INSERT INTO Categories (CategoryId, Name, Description) VALUES (6,'Circular Saws','A Circular saw is the perfect power tool for cutting straight, clean and true. Use one on heavy timber, sheet materials or man-made boards like MDF and you will see how quickly and easily you can make cuts that are perhaps messy or cumbersome with other saws.')");
            Sql("INSERT INTO Categories (CategoryId, Name, Description) VALUES (7,'Mitre Saws','Mitre saws are known for precision and accuracy when it comes to cutting through long pieces of wood and other materials. Looking a bit like a circular saw on a swivelling base there are many features and styles to become familiar with.')");
            Sql("INSERT INTO Categories (CategoryId, Name, Description) VALUES (8,'Nail Guns','A nail gun, nailgun or nailer is a type of tool used to drive nails into wood or some other kind of material.')");
            Sql("INSERT INTO Categories (CategoryId, Name, Description) VALUES (9,'Reciprocating Saws','Reciprocating saws are mainstays of the jobsite. No matter what you are cutting, be it metal, timber, plaster, drywall, plastic tubing, and more, it is the ideal professional power tool for quickly cutting through whatever you need to cut through')");
            Sql("INSERT INTO Categories (CategoryId, Name, Description) VALUES (10,'Grinders','Grinders have perhaps been viewed as tools that you only use if you have got a very quick job to undertake, such as a couple of cuts, or to quickly deburr some material, nowadays you can expect them to perform like corded grinders.')");
        }
        
        public override void Down()
        {
        }
    }
}
