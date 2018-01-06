using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.ViewModels
{
    public class RentalListViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="Customer")]
        public string CustomerName   { get; set; }

        [Required]
        [Display(Name = "Movie")]
        public string MovieName { get; set; }

        [Required]
        [Display(Name = "Date Rented")]
        public DateTime DateRented { get; set; }
        
        [Display(Name = "Date Returned")]
        public DateTime? DateReturned { get; set; }
    }
}
