using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace HotelListing5._0.Models

{
    public class CreateHotelDTO
    {
        [Required]
        [StringLength(maximumLength: 150, ErrorMessage = "Hotel Name is too Long")]

        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 250, ErrorMessage = "Address Name is too Long")]

        public string Address { get; set; }

        [Required]
        [Range(1,5)]

        public double Ranting { get; set; }

        [Required]

        public int CountrId { get; set; }
    }

    public class HotelDTO : CreateHotelDTO
    {
        
        public int Id { get; set; }

        public CountryDTO Country { get; set; }
                
    }

    
}
