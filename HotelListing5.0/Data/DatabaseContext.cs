using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing5._0.Controllers.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
                        
        }
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<Country>().HasData(

        //        new Country 
        //        {
        //            Id = 1, 
        //            Name = "Jamaica",
        //            Shortname = "JM"
        //        },
        //        new Country
        //        {
        //            Id = 2,
        //            Name = "Bahamas",
        //            Shortname = "BS"
        //        },
        //        new Country
        //        {
        //            Id = 3,
        //            Name = "Cayman Island",
        //            Shortname = "CI"
        //        }

        //        );
        //    builder.Entity<Hotel>().HasData(
                
        //        new Hotel
        //        {
        //            Id = 1,
        //            Name = "Sandals Resort and Spa",
        //            Address = "Negril",
        //            CountrId = 1,
        //            Ranting = 4.5
        //        },
        //        new Hotel
        //        {
        //            Id = 2,
        //            Name = "Comfort Suites",
        //            Address = "George Town",
        //            CountrId = 3,
        //            Ranting = 4
        //        },

        //         new Hotel
        //         {
        //             Id = 3,
        //             Name = "Grand Palldium",
        //             Address = "Nassua",
        //             CountrId = 2,
        //             Ranting = 4
        //         }

        //        );
        //}

        public DbSet<Country> Countries { get; set; }

        public DbSet<Hotel> Hotels { get; set; }

    }
}
