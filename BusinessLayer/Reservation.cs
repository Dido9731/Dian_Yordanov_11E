using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessLayer
{
    public class Reservation
    {

        public Reservation(int id, int seats, int tickets, decimal price, Flight flight, Airport airport = null)
        {
            Id = id;
            Seats = seats;
            Tickets = tickets;
            Price = price;
            Flight = flight;
        }

        [Key]
        public int Id { get; set; }
        [Range(0, 1000)]
        public int Seats { get; set; }
        [Range(0, 1000)]
        public int Tickets { get; set; }
        [Range(0, 1000)]
        public decimal Price { get; set; }
        [Required]
        public Flight Flight { get; set; }
        public int FlightId { get; set; }

        private Reservation()
        {

        }
    }
}
