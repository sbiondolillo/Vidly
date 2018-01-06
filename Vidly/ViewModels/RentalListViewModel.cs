using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class RentalListViewModel
    {
        public RentalListViewModel()
        {
        }

        public string CustomerName   { get; set; }
        public string MovieName { get; set; }
        public DateTime DateRented { get; set; }
    }
}
