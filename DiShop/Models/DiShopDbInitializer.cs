using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiShop.Models
{
    public class DiShopDbInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DiShopDbContext>
    {
        protected override void Seed(DiShopDbContext context)
        {
            var armors = new List<Armor>
            {
                new Armor{Id=new Guid("159370F0-2554-E711-A9D7-3085A911C1C7"), ArmorLevel= "Level 1"},
                new Armor{Id=new Guid("169370F0-2554-E711-A9D7-3085A911C1C7"), ArmorLevel= "Level 2"},
                new Armor{Id=new Guid("5AD743F7-2554-E711-A9D7-3085A911C1C7"), ArmorLevel= "Level 3"}
            };

            armors.ForEach(s => context.Armors.Add(s));
            context.SaveChanges();
            var vehicles = new List<Vehicle>
            {
                new Vehicle{Id=new Guid("8F8887DE-2654-E711-A9D7-3085A911C1C7"),Name= "M1 Abrams",YearOfDesigned= 1979, Cost = 8920000, Weight = 54000, Length = 9770, Width = 3660, Height = 2440, Crew = 4, ArmorId = new Guid("169370F0-2554-E711-A9D7-3085A911C1C7")},
                new Vehicle{Id=new Guid("86938F23-2954-E711-A9D7-3085A911C1C7"),Name= "M2 Bradley",YearOfDesigned= 1981, Cost = 1840000, Weight = 27600, Length = 6550, Width = 3600, Height = 2980, Crew = 3, ArmorId = new Guid("159370F0-2554-E711-A9D7-3085A911C1C7")},
                new Vehicle{Id=new Guid("5997EFF8-2954-E711-A9D7-3085A911C1C7"),Name= "IAV Stryker",YearOfDesigned= 2002, Cost = 5110000, Weight = 18770, Length = 6950, Width = 2720, Height = 2640, Crew = 2, ArmorId = new Guid("159370F0-2554-E711-A9D7-3085A911C1C7")},
                new Vehicle{Id=new Guid("96C43B65-2A54-E711-A9D7-3085A911C1C7"),Name= "LAV-25",YearOfDesigned= 1983, Cost = 2420000, Weight = 12800, Length = 6390, Width = 2500, Height = 2690, Crew = 3, ArmorId = new Guid("159370F0-2554-E711-A9D7-3085A911C1C7")},
                new Vehicle{Id=new Guid("8F7C1DBE-2A54-E711-A9D7-3085A911C1C7"),Name= "AAVP7A1 RAM/RS",YearOfDesigned= 1972, Cost = 1950000, Weight = 29100, Length = 7940, Width = 3270, Height = 3260, Crew = 3, ArmorId = new Guid("5AD743F7-2554-E711-A9D7-3085A911C1C7")}
            };
            vehicles.ForEach(s => context.Vehicles.Add(s));
            context.SaveChanges();
        }
    }
}