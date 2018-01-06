using System.Collections.Generic;

namespace Vidly.DTOs
{
    public class RentalDTO
    {
        public int CustomerId { get; set; }
        
        public List<int> MovieIds { get; set; }
    }
}