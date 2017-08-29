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
                    BrandId = 1,
                    CategoryId = 1,
                    Title = "Dewalt DCD740",
                    Price = 119.99M,
                    ProductImgUrl = "/Content/Images/Dewalt/Dewalt DCD740.jpg",
                    Description = "The Dewalt DCD740N is part of the Dewalt XR Lithium-ion cordless range which offers eXtreme run time, increased efficiency and improved performance. By constantly monitoring tool and battery operation the intelligent switch module maximises performance and prevents damage caused by overload or temperature build - up This technology combined with a tough outer casing "
                },
                new Product
                {
                    ProductId = 2,
                    BrandId = 2,
                    CategoryId = 1,
                    Title = "Makita DDA351Z 18v Li-ion Angle Drill Driver Body",
                    Price = 143.99M,
                    ProductImgUrl = "/Content/Images/Makita/Makita DDA351Z.jpg",
                    Description = "The DDA351Z 18v Lithium-ion angle drill/driver features a no load speed of 1800rpm producing 13.7Nm max torque, variable speed including reverse, 93mm head height, 10mm keyless chuck, drilling up to 10mm into steel and 25mm into wood making it ideal for use in a variety of materials and applications."
                },
                 new Product
                 {
                     ProductId = 3,
                     BrandId = 7,
                     CategoryId = 1,
                     Title = "Milwaukee C18 RAD-0 18V Li-ion Angle Driver - Body Only",
                     Price = 144.50M,
                     ProductImgUrl = "/Content/Images/Milwaukee/Milwaukee C18 RAD-0 18V.jpg",
                     Description = "Producing a 1500rpm no load speed delivering a 20Nm max torque with a perfect speed to power ratio for fast application performance, drilling up to 28mm into wood & 10mm into steel making it ideal for a wide range of applications."
                 },
                 new Product
                 {
                     ProductId = 4,
                     BrandId = 4,
                     CategoryId = 1,
                     Title = "Hitachi DN18DSL 18v Li-ion Angle Drill (Body Only)",
                     Price = 109M,
                     ProductImgUrl = "/Content/Images/Hitachy/Hitachi DN18DSL 18v.jpg",
                     Description = "The Hitachi DN18DSL 18v Li-ion Angle Drill Driver (Body Only) is compatible with the full range of 18v slide tools. Accepts all Hitachi 18v Li-ion slide batteries from 1.5Ah to 5.0Ah."
                 },
                 new Product
                 {
                     ProductId = 5,
                     BrandId = 3,
                     CategoryId = 1,
                     Title = "Bosch GWI10.8V-LI 10.8v Cordless Angle Li-ion Driver - Body Only",
                     Price = 118.50M,
                     ProductImgUrl = "/Content/Images/Bosch/Bosch GWI10.8V-LI.jpg",
                     Description = "The Bosch GWI10.8V-LI I-Driver has a 5 position head that can be rotated to 0, 22.5, 45, 67.5 and 90 degrees The GWI10.8V-LI is powered by lithium ion technology and can be left unused without self discharging and can be part charged with no damage to batteries, the turbo charge means in 15 minutes your battery is 70% charged and complete in a further 15 minutes."
                 },
                 new Product
                 {
                     ProductId = 6,
                     BrandId = 7,
                     CategoryId = 2,
                     Title = "Milwaukee M12CDD402C 12V 4.0Ah Lithium-ion Cordless ",
                     Price = 199.20M,
                     ProductImgUrl = "/Content/Images/Milwaukee/Milwaukee M12CDD402C.jpg",
                     Description = "Milwaukee M12CDD402C 12v 4.0Ah RED Lithium-ion FUEL Brushless Drill Driver features the Milwaukee® designed and built brushless POWERSTATE™ motor for up to 10x longer motor life, up to 2x more power and up to 2x more run time."
                 },
                new Product
                {
                    ProductId = 7,
                    BrandId = 3,
                    CategoryId = 2,
                    Title = "Panasonic EY74A2LJ3G31R2",
                    Price = 227.99M,
                    ProductImgUrl = "/Content/Images/Panasonic/Panasonic EY74A2LJ3G31R2.jpg",
                    Description = "Panasonic EY74A2LJ3G31R2 14.4v & 18v Brushless Drill Driver is supplied with 2 x 5.0Ah Li-ion Batteries, 80 min Charger & Case. This Brushless Drill Driver offers a compact body at just 178mm with a lighter, yet more powerful motor compared to the brushed equlivant.Having a brushless motor means that none of the energy generated by the battery is wasted on friction and heat from carbon brushes.Instead all of that energy goes into the job you're doing which means that it is more efficient, concentrated and runtimes are increased."
                },
                new Product
                {
                    ProductId = 8,
                    BrandId = 3,
                    CategoryId = 2,
                    Title = "Bosch GSR 18V-60 C 18v Cordless Brushless 2 Speed Drill Driver",
                    Price = 238.50M,
                    ProductImgUrl = "/Content/Images/Bosch/Bosch GSR 18V-60 C 18v.jpg",
                    Description = "Personalised settings such as precision clutch for a reduction of wear-out and longer lifetime, thanks to controlled over ratcheting system can be adjusted and saved via smartphone for adaptability to needs."
                },
                new Product
                {
                    ProductId = 9,
                    BrandId = 1,
                    CategoryId = 2,
                    Title = "Dewalt DCD990P2 18v 5.0Ah XRP Brushless Drill Driver",
                    Price = 349M,
                    ProductImgUrl = "/Content/Images/Dewalt/Dewalt DCD990P2 18v.jpg",
                    Description = "The Dewalt DCD990P2 is the newest addition to the Dewalt XR 4.0Ah cordless range. The DCD990 is a cordless hammer drill driver, otherwise known as a combi drill. Its heavy duty drill giving you an impressive 80Nm of torque making it perfect for large drill bits and tough materials."
                },
                 new Product
                 {
                     ProductId = 10,
                     BrandId = 2,
                     CategoryId = 2,
                     Title = "Makita DDF480RMJ 18v Lithium-ion 4.0Ah Drill/Driver",
                     Price = 324.30M,
                     ProductImgUrl = "/Content/Images/Makita/Makita DDF480RMJ 18v.jpg",
                     Description = "The DDF480RMJ 18v Lithium-ion 2 speed cordless drill driver features powerful 370w motor producing a max 1500rpm no load speed providing a high 54Nm max torque with 16 position adjustable torque control for uniform results and optimized precision, 2 speed/variable speed all metal gearbox including reverse for extra-high transmission durability, 13mm single sleeve keyless chuck, drilling up to 13mm into steel and 38mm into wood making it ideal for use in a variety of materials."
                 },
                 new Product
                 {
                     ProductId = 11,
                     BrandId = 6,
                     CategoryId = 2,
                     Title = "BlackandDecker BDCDDBT120C 20V MAX Lithium Cordless Drill / Driver",
                     Price = 276M,
                     ProductImgUrl = "/Content/Images/BlackAndDecker/BlackandDecker BDCDDBT120C 20V.jpg",
                     Description = "Bring your project ideas to life with this compact and powerful cordless drill and driver. Its lightweight design and built-in LED light allows you to work in tight or dark spaces. Manage the SMARTECH battery remotely via the BLACK+DECKER app and use it as a portable charger to charge your mobile devices for ultimate convenience."
                 },
                  new Product
                  {
                      ProductId = 12,
                      BrandId = 4,
                      CategoryId = 2,
                      Title = "Hitachi DS18DSDL 18V DRILL DRIVER WITH 1 X 5.0AH LI-ION BATTERY",
                      Price = 266.30M,
                      ProductImgUrl = "/Content/Images/Hitachy/Hitachi DS18DSDL 18V.jpg",
                      Description = "Standard Accessories: 1 x BSL1850 high capacity 5.0Ah Li-Ion battery, UC18YRSL charger, Side handle, Driver bit, Carrying case."
                  },
                  new Product
                  {
                      ProductId = 13,
                      BrandId = 8,
                      CategoryId = 2,
                      Title = "Ryobi RCD18-L13S 18V CORDLESS DRILL/DRIVER (1X1.3AH)",
                      Price = 278.60M,
                      ProductImgUrl = "/Content/Images/Ryobi/Ryobi RCD18-L13S 18V.jpg",
                      Description = "Superb little drill, nice low profile sides mean I can get into tight spaces at a very low angle. The best bit is the torque, I drove a 100mm high - grip screw through a securing block straight into a hard - wood door - jamb without any noticeable drop in speed as it went in."
                  },
                   new Product
                   {
                       ProductId = 14,
                       BrandId = 3,
                       CategoryId = 3,
                       Title = "Bosch GST 18V-LIBN Li-ion Jigsaw - Body Only",
                       Price = 114.90M,
                       ProductImgUrl = "/Content/Images/Bosch/Bosch GST 18V-LIBN.jpg",
                       Description = "This impressive jigsaw from Bosch joins the ever increasing 18v Li-ion 'Blue' professional range of cordless power tools. Its Improved metal footplate and plastic cover which gives the user more stability when cutting near corners and edges, also more control when cutting slim or small pieces of materials."
                   },
                   new Product
                   {
                       ProductId = 15,
                       BrandId = 1,
                       CategoryId = 3,
                       Title = "Dewalt DCS331N4 Dewalt 18V Li-ion Jigsaw Body + 1 x 4.0ah Battery",
                       Price = 159.99M,
                       ProductImgUrl = "/Content/Images/Dewalt/Dewalt DCS331N4 Dewalt 18V.jpg",
                       Description = "Dewalt DCS331 18v Li-ion Cordless Jigsaw Body Only With 1 x 4.0Ah Li-ion Battery with Charger or Case."
                   },
                new Product
                {
                    ProductId = 16,
                    BrandId = 4,
                    CategoryId = 3,
                    Title = "Hitachi CJ18DSL/L4",
                    Price = 113.99M,
                    ProductImgUrl = "/Content/Images/Hitachy/Hitachi CJ18DSL.jpg",
                    Description = "Hitachi CJ18DSL jigsaw with its ergonomically designed handle and weight of only 2.4kg it is both easy and comfortable to use and light enough to reduce user fatigue, keeping you going longer on the job. "
                },
                new Product
                {
                    ProductId = 17,
                    BrandId = 2,
                    CategoryId = 3,
                    Title = "Makita DJV140RFE 14.4V LXT JIGSAW",
                    Price = 159M,
                    ProductImgUrl = "/Content/Images/Makita/Makita DJV140RFE 14.4V.jpg",
                    Description = "Models DJV140 are cordless jig saws powered by 3.0Ah Li-ion battery, featuring a compact and lightweight design."
                },
                new Product
                {
                    ProductId = 18,
                    BrandId = 7,
                    CategoryId = 3,
                    Title = "Milwaukee M18BJS0 18v Li-ion Jigsaw ",
                    Price = 198.15M,
                    ProductImgUrl = "/Content/Images/Milwaukee/Milwaukee M18BJS0 18v.jpg",
                    Description = "Milwaukee M18BJS0 high performance motor delivers maximum power whilst maximising the power to weight ratio. Producing a max 2800spm no load stroke rate with a 25mm stroke length delivering 10mm max cutting capacity in steel and 135mm max cutting capacity in wood."
                },
                new Product
                {
                    ProductId = 19,
                    BrandId = 9,
                    CategoryId = 3,
                    Title = "Panasonic EY4541LS1S 14.4V CORDLESS JIGSAW INC 4.2AH BATT",
                    Price = 229.40M,
                    ProductImgUrl = "/Content/Images/Panasonic/Panasonic EY4541LS1S 14.4V.jpg",
                    Description = " Panasonic 50min. usable and 60min. full charging.Counter balance mechanism for reduced vibration and Cutting angle adjustment(0 - 45°). 4 cutting movements with Electronic stroke rate stabilization."
                },
                new Product
                {
                    ProductId = 20,
                    BrandId = 2,
                    CategoryId = 4,
                    Title = "Makita DKP180Z",
                    Price = 179.99M,
                    ProductImgUrl = "/Content/Images/Makita/Makita DKP180Z.jpg",
                    Description = "It is plain to see why the Makita DKP180Z 18V Lithium-ion cordless planer is ideal for site and workshop alike. Developed with the same advantages of the KP0800 mains planer, the DKP180Z planer provides a no load speed of 14000rpm, delivering an 82mm planning width, 2mm maximum planning depth per pass and impressive rebate depth of 9mm. It us equipped with a simple to use."
                },
                new Product
                {
                    ProductId = 21,
                    BrandId = 3,
                    CategoryId = 4,
                    Title = "Bosh GHO 18 V-LI 18V 4.0AH LI-ION CORDLESS PLANER",
                    Price = 455.60M,
                    ProductImgUrl = "/Content/Images/Bosch/Bosh GHO 18 V-LI 18V.jpg",
                    Description = "Lightweight and precise planer with up to 1.6mm depth of cut and a 8mm rebate capacity. Quick and easy blade change for continuous work. Premium surface quality due to ultra-sharp and robust TC reversible blade. Safety guaranteed with motor brake feature."
                },
                new Product
                {
                    ProductId = 22,
                    BrandId = 1,
                    CategoryId = 4,
                    Title = "Dewalt DCP580N4 18v XR Li-ion Brushless Cordless Planer 1 x 4.0Ah",
                    Price = 189.50M,
                    ProductImgUrl = "/Content/Images/Dewalt/Dewalt DCP580N4 18v.jpg",
                    Description = "The DCP580 is the first Planer to join Dewalts impressive XR 18v li-ion family. Because it joins the XR range we can be assured that its compatible with the full range of 18v li-ion XR batteries from 2.0Ah to 5.0Ah."
                },
                new Product
                {
                    ProductId = 23,
                    BrandId = 4,
                    CategoryId = 4,
                    Title = "Hitachi P18DSL L4 18v Lithium-Ion Cordless Planer Body",
                    Price = 109M,
                    ProductImgUrl = "/Content/Images/Hitachy/Hitachi P18DSL L4 18v.jpg",
                    Description = "This brand new 18v Planer planer provides a no load speed of 16000rpm, delivering an 82mm planning width, a 2mm maximum planning depth per pass and an impressive rebate depth of 9mm."
                },
                new Product
                {
                    ProductId = 24,
                    BrandId = 7,
                    CategoryId = 4,
                    Title = "Milwaukee M18 BP0 18v Planer - Body Only",
                    Price = 160.40M,
                    ProductImgUrl = "/Content/Images/Milwaukee/Milwaukee M18 BP0 18v.jpg",
                    Description = "The Milwuakee 18v Planer Body comes supplied with no batteries, case or charger. The M18 BP0 joins the every increasing and popular Milwuakee 18v Li - ion range and us therefore compatible with any 18V li - ion Milwaukee battery."
                },
                new Product
                {
                    ProductId = 25,
                    BrandId = 8,
                    CategoryId = 4,
                    Title = "Ryobi CPL180MHG 18V CORDLESS PLANER",
                    Price = 190M,
                    ProductImgUrl = "/Content/Images/Ryobi/Ryobi CPL180MHG 18V.jpg",
                    Description = "To get the smoothest of surface during any stage of a project, the 18V Cordless Planer offers great results. A positive depth adjustment of 0-0.4mm and chamfering groove in die-cast front shoe offers incredible precision so no patch is left not sanded. The extra front handle supplies added control with an included side fence and two reversible TCT blades maintaining the planer's high level of accuracy."
                },
                new Product
                {
                    ProductId = 26,
                    BrandId = 6,
                    CategoryId = 5,
                    Title = "PivotPlus 6V Rechargeable Screwdriver",
                    Price = 102M, 
                    ProductImgUrl = "/Content/Images/BlackAndDecker/PivotPlus6V Rechargeable Screwdriver.jpg",
                    Description = "Get the best results for each job with a rechargeable drill/driver that easily switches from drilling to driving. A 3-position handle helps you access tight spaces, and a built-in light illuminates work areas."
                },
                new Product
                {
                    ProductId = 27,
                    BrandId = 3,
                    CategoryId = 5,
                    Title = "Bosch GTB 12 V-11 12v Cordless Li-ion Brushless Drywall Screwdriver",
                    Price = 179M,
                    ProductImgUrl = "/Content/Images/Bosch/Bosch GTB 12 V-11 12v.jpg",
                    Description = "Bosch GTB 12V-11 Professional Cordless Brushless Drywall Screwdriver, the perfect solution for occasional drywall applications, cost-effective and lightweight with professional performance."
                },
                new Product
                {
                    ProductId = 28,
                    BrandId = 1,
                    CategoryId = 5,
                    Title = "Dewalt DCF680G2 7.2V Cordless Motion Activated Screwdriver",
                    Price = 109.99M,
                    ProductImgUrl = "/Content/Images/Dewalt/Dewalt DCF680G2 7.2V.jpg",
                    Description = "DEWALT DCF680G2 Motion Activated Screwdriver, powerful 7.2V Screwdriver for screwdriving applications."
                },
                new Product
                {
                    ProductId = 29,
                    BrandId = 2,
                    CategoryId = 5,
                    Title = "Makita DF001DW 3.6v li-ion Pencil Screwdriver",
                    Price = 70M,
                    ProductImgUrl = "/Content/Images/Makita/Makita DF001DW 3.6v.jpg",
                    Description = "Makita DF001DW  is a cost-effective, lightweight in-line cordless screwdriver powered by 3.6V 1.5Ah in-built Li-ion battery."
                },
                new Product
                {
                    ProductId = 30,
                    BrandId = 3,
                    CategoryId = 6,
                    Title = "Bosch GKS 18V LIN 18v Li-ion Circular Saw - with batery",
                    Price = 150M,
                    ProductImgUrl = "/Content/Images/Bosch/Bosch GKS 18V.jpg",
                    Description = "The Bosch GKS 18V LIN 18V cordless Circular Saw that makes up part of Bosch's 18v Li-ion range. It has an impressive sturdy design and makes the most of the latest Bosch cordless power tool technology.It includes the EMP(Electronic Motor Protection) that is found in most Bosch cordless tools which helps fight against overheating, over discharge and helps gives the tools an extended lifetime."
                },
                new Product
                {
                    ProductId = 31,
                    BrandId = 1,
                    CategoryId = 6,
                    Title = "Dewalt DCS575T2 54v XR FLEXVOLT Li-ion Circular Saw",
                    Price = 378M,
                    ProductImgUrl = "/Content/Images/Dewalt/Dewalt DCS575T2 54v.jpg",
                    Description = "The Dewalt DCS575T2 is a 54v FLEXVOLT XR Lithium-ion Circular Saw with 2 x 54v Li-ion Batteries, T-STAK Carry Case and Charger 54v FLEXVOLT XR is an incredible new bit of technology is a huge jump forward for Dewalt and their already impressive range of cordless power tools.FLEXVOLT XR is a new range of cordless tools, batteries and chargers which are based on a 54 volt lithium - ion battery platform.All the tools on the FLEXVOLT platform are going to be, 54v, cordless and brushless giving you incredible runtimes, unrivaled power and increased capacities across the board."
                },
                new Product
                {
                    ProductId = 32,
                    BrandId = 4,
                    CategoryId = 6,
                    Title = "Hitachi C18DBAL W4 18v Brushless Circular Saw - Body Only",
                    Price = 164.30M,
                    ProductImgUrl = "/Content/Images/Hitachy/Hitachi C18DBAL W4 18v.jpg",
                    Description = "The C18DBAL/L4 joins the ranks of the new Hitachi 18v Li-ion Cordless & Brushless range. Its a circular saw which combines excellent build quality with a lightweight frame and incredible runtimes."
                },
                new Product
                {
                    ProductId = 33,
                    BrandId = 2,
                    CategoryId = 6,
                    Title = "Makita DHS680Z 18v Li-ion Brushless Circular Saw 165mm - With Batery",
                    Price = 149M,
                    ProductImgUrl = "/Content/Images/Makita/Makita DHS680Z Makita 18v.jpg",
                    Description = "The DHS680 is Makita's first brushless circular saw, becoming one of the latest members of Makita's impressive line up of 18v Lithium-ion cordless tools."
                },
                new Product
                {
                    ProductId = 34,
                    BrandId = 7,
                    CategoryId = 6,
                    Title = "Milwaukee 4933451377 18v Fuel Brushless 165mm Circular Saw 5.0Ah",
                    Price = 389M,
                    ProductImgUrl = "/Content/Images/Milwaukee/Milwaukee 4933451377 18v.jpg",
                    Description = "Milwaukee M18 FUEL 4933451377 Circular Saw with 2 x 5.0Ah Batteries and fast charger. High performance and innovative circular saw that holds a 165mm blade and features 15.87mm bore size, Max.cutting depth at 45° of 41mm and Max.cutting dept at 90° of 55mm and 50° bevel capacity."
                },
                new Product
                {
                    ProductId = 35,
                    BrandId = 9,
                    CategoryId = 6,
                    Title = "Panasonic EY45A2LJ2G31 14.4v/18v Li-ion Multi-Purpose Cutter - 2 x 5.0Ah Batteries",
                    Price = 289.70M,
                    ProductImgUrl = "/Content/Images/Panasonic/Panasonic EY45A2LJ2G31.jpg",
                    Description = "Panasonic Tough Tool products survive on any work site no matter how tough the jobs. With effective dust and water protection the tough tool will continue to function no matter how bad the conditions get and with features such as battery sensors, the tool protects itself from overcharging and overdischarging. Also a temperature sensor helps protect the battery from over heating by shutting down the machine and flashing a warning light before the damage is done."
                },
                new Product
                {
                    ProductId = 36,
                    BrandId = 6,
                    CategoryId = 6,
                    Title = "Black and Decker BDECS300C 13 Amp Circular Saw with Laser",
                    Price = 290M,
                    ProductImgUrl = "/Content/Images/BlackAndDecker/Black and Decker BDECS300C 13 Amp.jpg",
                    Description = "The 13 amp 7-1/4 inch circular saw with laser cut line guide has the power you need to tackle tough jobs. The laser cut line guide provides you with added confidence to make clean and accurate cuts. The 13 amp circular saw with laser is also equipped with a convenient spindle lock, allowing for easy blade changes."
                },
                  new Product
                  {
                      ProductId = 37,
                      BrandId = 8,
                      CategoryId = 6,
                      Title = "Ryobi R18CS-L40S 18V CORDLESS CIRCULAR SAW (1X 4.0AH)",
                      Price = 294.80M,
                      ProductImgUrl = "/Content/Images/Ryobi/Ryobi R18CS-L40S 18V.jpg",
                      Description = "Ideal for making long straight cuts, trimming sheet wood to size, cutting kitchen work tops, flooring or to make quick and accurate cross cuts in timber. Impressive cut capacities 52mm at 90°, 36mm at 45° allows you to complete applications usually reserved for corded tools."
                  },
                  new Product
                  {
                      ProductId = 38,
                      BrandId = 1,
                      CategoryId = 7,
                      Title = "Dewalt DCS777T2 54v XR FLEXVOLT Li-ion Cordless 216mm Mitre Saw - 2 x Batteries",
                      Price = 504M,
                      ProductImgUrl = "/Content/Images/Dewalt/Dewalt DCS777T2 54v.jpg",
                      Description = "54v FLEXVOLT XR is an incredible new bit of technology is a huge jump forward for Dewalt and their already impressive range of cordless power tools. FLEXVOLT XR is a new range of cordless tools, batteries and chargers which are based on a 54 volt lithium-ion battery platform. All the tools on the FLEXVOLT platform are going to be 54v, cordless and brushless giving you incredible runtimes, unrivaled power and increased capacities across the board."
                  },
                  new Product
                  {
                      ProductId = 39,
                      BrandId = 2,
                      CategoryId = 7,
                      Title = "Makita DLS714Z Twin 18v LXT Li-ion Brushless Slide Compound Mitre Saw - Body Only",
                      Price = 458M,
                      ProductImgUrl = "/Content/Images/Makita/Makita DLS714Z Twin 18v.jpg",
                      Description = "The Makita DLS714Z is a Brushless, cordless mitre saw that runs off 2 x 18v Li-ion batteries. It joins the ever increasing range of Makita 18v Li-ion tools."
                  },
                   new Product
                   {
                       ProductId = 40,
                       BrandId = 7,
                       CategoryId = 7,
                       Title = "Milwaukee M18 SMS216-0 18v Li-ion Cordless Mitre Saw Body",
                       Price = 361M,
                       ProductImgUrl = "/Content/Images/Milwaukee/Milwaukee M18 SMS216-0 18v.jpg",
                       Description = "This powerful 2-pole frameless motor delivers 2700rpm for fast cutting of materials. The built in Redlink overload protection electronics in the tool and battery pack delivers the best class of durability."
                   },
                   new Product
                   {
                       ProductId = 41,
                       BrandId = 1,
                       CategoryId = 8,
                       Title = "Dewalt DCN692 Cordless 18v XR Li-ion Framing Nailer - With Batery",
                       Price = 399.99M,
                       ProductImgUrl = "/Content/Images/Dewalt/Dewalt DCN692 Cordless 18v.jpg",
                       Description = "The Dewalt DCN692N 18V XR Li-ion framing nailer features brushless motor technology offering the power to fire a 90mm ring shank nail into softwood & 63mm into hardwoods."
                   },
                   new Product
                   {
                       ProductId = 42,
                       BrandId = 4,
                       CategoryId = 8,
                       Title = "Hitachi NT1865DBSL/JX 18V 16 GAUGE BRUSHLESS STRAIGHT FINISH NAILER",
                       Price = 360M,
                       ProductImgUrl = "/Content/Images/Hitachy/Hitachi NT1865DBSL 18V.jpg",
                       Description = "All new design cordless finish nailer with brushless motor for longer run time, less maintenance and increased durability."
                   },
                   new Product
                   {
                       ProductId = 43,
                       BrandId = 2,
                       CategoryId = 8,
                       Title = "Makita GN900SEX1 Makita Cordless Gas Framing Nailer Kit - With 2X Bateries",
                       Price = 449M,
                       ProductImgUrl = "/Content/Images/Makita/Makita GN900SEX1.jpg",
                       Description = "The GN900SE gas framing nailer is ideal for timber frame erection, floor boarding, roof battening, decking, flat roofing, chipboard, shuttering, cladding, joists and a host of other applications."
                   },
                    new Product
                    {
                        ProductId = 44,
                        BrandId = 3,
                        CategoryId = 9,
                        Title = "Bosch GSA 18V-32 18v Cordless Li-ion Brushless Sabre Saw",
                        Price = 420M,
                        ProductImgUrl = "/Content/Images/Bosch/Bosch GSA 18V-32.jpg",
                        Description = "Brushless EC motor, when paired with an 18V Bosch Lithium-Ion Technology battery, delivers corded power with cordless freedom, longer motor life, more runtime and more power."
                    },
                    new Product
                    {
                        ProductId = 45,
                        BrandId = 1,
                        CategoryId = 9,
                        Title = "Dewalt DCS388T2 54v XR FLEXVOLT Li-ion Reciprocating Saw",
                        Price = 368M,
                        ProductImgUrl = "/Content/Images/Dewalt/Dewalt DCS388T2 54v.jpg",
                        Description = "54v FLEXVOLT XR is an incredible new bit of technology is a huge jump forward for Dewalt and their already impressive range of cordless power tools. FLEXVOLT XR is a new range of cordless tools, batteries and chargers which are based on a 54 volt lithium-ion battery platform. All the tools on the FLEXVOLT platform are going to be 54v, cordless and brushless giving you incredible runtimes, unrivaled power and increased capacities across the board."
                    },
                    new Product
                    {
                        ProductId = 46,
                        BrandId = 2,
                        CategoryId = 9,
                        Title = "Makita DJR182Z5 Li-ion 18v Recip Saw Body (1 x 5.0Ah)",
                        Price = 148.20M,
                        ProductImgUrl = "/Content/Images/Makita/Makita DJR182Z5 Li-ion 18v.jpg",
                        Description = "The DJR182Z reciprocating saw features variable speed providing no load speed of 2900 strokes per minute for increased cutting efficiency, delivering a 28mm stroke length with a max cutting capacity of 255mm in wood, max cutting capacity in pipe of 130mm."
                    },
                     new Product
                     {
                         ProductId = 47,
                         BrandId = 4,
                         CategoryId = 9,
                         Title = "Hitachi CR18DSL 18v Cordless Reciprocating Saw Body Only",
                         Price = 119.99M,
                         ProductImgUrl = "/Content/Images/Hitachy/Hitachi CR18DSL 18v.jpg",
                         Description = "Hitachi CR18DSL/L4 18v Cordless Reciprocating Saw is part of the Hitachi 18V Li-ion Slide-on Battery Range and is great addition to anybody's Hitachi 18v kit, whether just starting out or looking to add to an already established tool kit."
                     },
                     new Product
                     {
                         ProductId = 48,
                         BrandId = 6,
                         CategoryId = 9,
                         Title = "Black and Decker BDCR20B 20V MAX Lithium Reciprocating Saw - Battery and Charger Included",
                         Price = 200M,
                         ProductImgUrl = "/Content/Images/BlackAndDecker/Black and Decker BDCR20B 20V.jpg",
                         Description = "Versatile, lightweight and easy to use.  This cordless reciprocating saw features a powerful 3000 spm motor while the variable speed trigger and electric brake provide additional control."
                     },
                     new Product
                     {
                         ProductId = 49,
                         BrandId = 3,
                         CategoryId = 10,
                         Title = "Bosch GWS 18V LIN 18v Li-ion Grinder - Body Only",
                         Price = 93M,
                         ProductImgUrl = "/Content/Images/Bosch/Bosch GWS 18V LIN 18v.jpg",
                         Description = "The Bosch GWS 18V LIN  18V cordless Angle Grinder with no batteries, no case and no charger."
                     },
                      new Product
                      {
                          ProductId = 50,
                          BrandId = 1,
                          CategoryId = 10,
                          Title = "Dewalt DCG405P2-GB 18v XR Brushless 125mm Angle Grinder 2 x 5.0Ah Battery",
                          Price = 369M,
                          ProductImgUrl = "/Content/Images/Dewalt/Dewalt DCG405P2-GB 18v.jpg",
                          Description = "The Dewalt DCG405 is part of the 18V XR (Extreme Runtime) range which provides cordless power tools with enhanced runtime, fitted with a Brushless motor for increased tool efficiency, plus improved performance and power for a wide range of applications on the job site."
                      },
                      new Product
                      {
                          ProductId = 51,
                          BrandId = 4,
                          CategoryId = 10,
                          Title = "Hitachi G18DSL 18V GRINDER WITH 2 X 5.0AH LI-ION BATTERIES",
                          Price = 400M,
                          ProductImgUrl = "/Content/Images/Hitachy/Hitachi G18DSL 18V.jpg",
                          Description = "Standard Accessories: 2 x BSL1850 high capacity 5.0Ah Li-Ion batteries, UC18YRSL fan cooled charger, Side handle, Abrasive wheel, Carrying case."
                      },
                       new Product
                       {
                           ProductId = 52,
                           BrandId = 2,
                           CategoryId = 10,
                           Title = "Makita DGA456Z3 18v LXT Li-ion Brushless Cordless Grinder 115mm + 3.0Ah Battery",
                           Price = 189M,
                           ProductImgUrl = "/Content/Images/Makita/Makita DGA456Z3 18v.jpg",
                           Description = "The DGA4546 builds on its predecessors the 452/454. The motor has been upgraded from a standard 4-pole motor to the much more energy efficient and longer lasting 'Brushless Motor' that is becoming more popular throughout the power tool world. Having a brushless motor allows this grinder to run longer per battery charge, get more power out of the battery and so achieve faster, and more efficient grinding."
                       },
                       new Product
                       {
                           ProductId = 53,
                           BrandId = 7,
                           CategoryId = 10,
                           Title = "Milwaukee HD28AG32X 28v Angle Grinder + 2x Batteries",
                           Price = 269.30M,
                           ProductImgUrl = "/Content/Images/Milwaukee/Milwaukee HD28AG32X 28v.jpg",
                           Description = "Powerful 28V High Power Milwaukee® motor delivers corded tool performance producing a max 9000rpm no load speed, the 125mm diameter disc producing a 36mm max cutting depth."
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
