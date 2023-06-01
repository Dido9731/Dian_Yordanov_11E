using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessLayer
{
    public class Flight
    {
        public Flight(int id, string destination, DateTime? time = null)
        {
            Id = id;
            Destination = destination;
            Time = time;
            Reservations = new List<Reservation>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Destination { get; set; }

        [Range(0, 1500)]
        public DateTime? Time { get; set; }

        public List<Reservation> Reservations { get; set; }

        private Flight()
        {
            Reservations = new List<Reservation>();
        }
    }
}
