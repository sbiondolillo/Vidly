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
        public string CustomerName { get; set; }

        [Required]
        public string MovieName { get; set; }

        [Required]
        public DateTime DateRented { get; set; }
        public DateTime? DateReturned { get; set; }
    }
}