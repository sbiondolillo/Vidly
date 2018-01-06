using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.DTOs;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class RentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        // POST: /api/rentals
        [HttpPost]
        public IHttpActionResult CreateRental(RentalDTO rentalDTO)
        {
            var customer = _context.Customers.Single(c => c.Id == rentalDTO.CustomerId);

            foreach (var movieId in rentalDTO.MovieIds)
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movieId);
                var newRental = new Rental() { Customer = customer, Movie = movieInDb, DateRented = DateTime.Now };
                _context.Rentals.Add(newRental);
            }

            _context.SaveChanges();

            return Ok();
        }

        
    }
}
