using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.DTOs;
using Vidly.Models;
using Vidly.ViewModels;
using AutoMapper;
using System.Data.Entity.Validation;

namespace Vidly.Controllers.Api
{
    public class RentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: /api/rentals
        public IHttpActionResult GetRentals()
        {
            var rentalDTOs = _context.Rentals
                .Include(r => r.Customer)
                .Include(r => r.Movie)
                .Select(Mapper.Map<Rental, RentalDTO>)
                .ToList();

            return Ok(rentalDTOs);
        }

        // POST: /api/rentals
        [HttpPost]
        public IHttpActionResult CreateRental(NewRentalDTO newRentalDTO)
        {
            var customer = _context.Customers.Single(c => c.Id == newRentalDTO.CustomerId);

            var movies = _context.Movies.Where(m => newRentalDTO.MovieIds.Contains(m.Id)).ToList();
            
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

        // PUT: api/rentals/{id}
        [HttpPut]
        public IHttpActionResult EditRental(int id, RentalDTO rentalDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var rentalInDb = _context.Rentals.SingleOrDefault(c => c.Id == id);

            if (rentalInDb == null)
            {
                return NotFound();
            }

            Mapper.Map(rentalDTO, rentalInDb);

            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {

                Console.WriteLine(e);
            }


            return Ok(Mapper.Map(rentalInDb, rentalDTO));
        }

        
    }

}
