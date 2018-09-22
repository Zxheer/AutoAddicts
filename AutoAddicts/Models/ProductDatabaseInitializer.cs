using System.Collections.Generic;
using System.Data.Entity;

namespace AutoAddicts.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));         
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Body Kits"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Batterys"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Rims"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Interior"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Golf R WideBody",
                    Description = "Wide body kit for Golf R 7.5, carbon fiber diffuser included.",
                    ImagePath="GolfR.jpg",
                    UnitPrice = 22.50,
                    CategoryID = 1,
                    Warranty = "6 months"
        },
                new Product
                {
                    ProductID = 2,
                    ProductName = "BMW 240i Quad Exhaust upgrade",
                    Description = "Upgrade for the BMW240i from dual to quad sports titanium exhaust pipes",
                    ImagePath="BMW240i.jpg",
                    UnitPrice = 15.95,
                     CategoryID = 1,
                     Warranty = "6 months"
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Mercedes A45 AMG Carbon Fiber Spoiler",
                    Description = "Carbon fiber wing that produces 20% more downforce than stock! Please note this wing will fit on any A class vehicle with the stock AMG sports package",
                    ImagePath="AMGA45.jpg",
                    UnitPrice = 32.99,
                    CategoryID = 1,
                    Warranty = "6 months"
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Audi S3 Sedan Carbon Fiber Side Skirts",
                    Description = "Carbon Fiber side skirts for the 2018 S3 Sedan comes with a free installation voucher",
                    ImagePath="AudiS3.jpg",
                    UnitPrice = 8.95,
                    CategoryID = 1,
                    Warranty = "6 months"
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Porsche 911 GT1 LM Carbon Fiber Hood Scoop",
                    Description = "Replaces the standard hood scoop with a carbon fiber version to add a 21st century element, to a 20th century monster.",
                    ImagePath="911GT1.jpg",
                    UnitPrice = 34.95,
                    CategoryID = 1,
                    Warranty = "6 months"
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Turn1™ 631 Car Battery",
                    Description = "The Turn1™ brand is an alternative automotive battery brand that will suit the budget conscious driver. The batteries are designed for small, medium and large passenger vehicles as well as SUV and light delivery and commercial vehicles.",
                    ImagePath="Turn1631.jpg",
                    UnitPrice = 95.00,
                    CategoryID = 2,
                    Warranty = "6 months"
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "ATLASBX 668 EFT Start-Stop Car Battery (RH+)",
                    Description = "ATLASBX car battery dealers across Southern Africa. Enhanced Flooded Battery (EFT) for larger start-stop cars, hybrids and entry-level start-stop functionality. Ideal for stop-start vehicles that are heavily equipped with electronic devices. EFT technology provides enhanced starting power for standard vehicles, allowing a longer battery lifespan of recovering from deep discharges than standard lead acid batteries.",
                    ImagePath="Atlasbx668.jpg",
                    UnitPrice = 4.95,
                    CategoryID = 2,
                    Warranty = "6 months"
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "ATLASBX 631 Car Battery",
                    Description = "24-month warranty. Passenger vehicles and trucks will benefit most from Sealed Maintenance Free designs which improve durability and increase the energy supply for larger cars.",
                    ImagePath="Atlasbx631.jpg",
                    UnitPrice = 2.95,
                    CategoryID = 2,
                    Warranty = "6 months"
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Duracell 619 Car Battery",
                    Description = "Duracell batteries were first created in the early 1920s by scientist Samuel Ruben and manufacturer Philip Rogers Mallory to power smaller devices. Decades later, they’ve been used to keep so many devices operational for such long periods of time, that the brand is synonymous with durability and premium quality. Combined with full calcium technology and a 4-chamber leak protection system, no other product is as ideal a match for the daily performance demands of modern vehicles.",
                    ImagePath="Duracell619.jpg",
                    UnitPrice = 32.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "22'' Mag Wheel - Black-Narrow",
                    Description = "Black Machined Face with Stainless Steel Polished  Lip"+
                                  "22x5x120 Pcd"+
                                  "22x9j Front & 22x10.5j Rear"+
                                  "Fits most BM Models,Amarok,SS Lumina",
                    ImagePath="22BNW.jpg",
                    UnitPrice = 15.00,
                    CategoryID = 3,
                    Warranty = "6 months"
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "22'' Mag Wheel - Matt Black & Silver",
                    Description = "Matt Black Finish with Silver"+
                                    "22x6x139 Pcd"+
                                   "22x9.5j all 4 Mag Wheels"+
                                   "Fits most Bakkies,SUV's",
                    ImagePath="22MBS.jpg",
                    UnitPrice = 26.00,
                    CategoryID = 3,
                    Warranty = "6 months"
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "20'' Mag Wheel - Chrome",
                    Description = "Full Chrome Mag Wheel"+
                                    "20x5x114/120 Pcd"+
                                    "20x8.5j all 4 Mag Wheels"+
                                    "Fits most Bakkies,SUV's",
                    ImagePath="20C.jpg",
                    UnitPrice = 29.00,
                    CategoryID = 3,
                    Warranty = "6 months"
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "20'' Mag Wheel - Matt Black",
                    Description = "Full Matt Black Wheel"+
                                    "20x5x108/114 Pcd"+
                                    "20x8.5j all 4 Mag Wheels"+
                                    "Fits most Bakkies,SUV's",
                    ImagePath="20MB,jpg",
                    UnitPrice = 95.00,
                    CategoryID = 3,
                    Warranty = "6 months"
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Mercedes Benz W211-E350-A272",
                    Description = "Sports ECU increases power by 20KW.",
                    ImagePath="W211.jpg",
                    UnitPrice = 4.95,
                    CategoryID = 4,
                    Warranty = "6 months"
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "BMW E65-730D-0281",
                    Description = "Performance ECU increases torque by 20Nm.",
                    ImagePath="E65.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4,
                    Warranty = "6 months"
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "JAGUAR-XF 9W8",
                    Description = "This ECU increases power and torque by 30Kw and 35Nm.",
                    ImagePath="XF.jpg",
                    UnitPrice = 122.95,
                    CategoryID = 4,
                    Warranty = "6 months"
                }
            };

            return products;
        }
    }
}