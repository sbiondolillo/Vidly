﻿using System;
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
            
            var movies = _context.Movies.Where(m => rentalDTO.MovieIds.Contains(m.Id)).ToList();
            
            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                {
                    return BadRequest("Movie is not available");
                }

                var newRental = new Rental() { Customer = customer, Movie = movie, DateRented = DateTime.Now };
                movie.NumberAvailable--;

                _context.Rentals.Add(newRental);
            }

            _context.SaveChanges();

            return Ok();
        }

        
    }
}
