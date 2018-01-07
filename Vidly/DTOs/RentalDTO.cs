using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.DTOs
{
    public class RentalDTO
    {
        public int Id { get; set; }

        [Required]
        public CustomerDTO Customer { get; set; }

        [Required]
        public MovieDTO Movie { get; set; }
        public DateTime DateRented { get; set; }
        public DateTime? DateReturned { get; set; }
    }
}