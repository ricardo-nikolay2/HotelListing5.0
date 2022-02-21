using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing5._0.Controllers.Data
{
    public class Hotel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public double Ranting { get; set; }

        [ForeignKey (nameof(Country)) ]
        
        public int CountrId { get; set; }

        public Country Country { get; set; }

        

    }
}
