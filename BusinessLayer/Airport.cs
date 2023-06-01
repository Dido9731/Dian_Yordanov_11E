using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class Airport
    {
        public Airport(int id, string name, decimal? income = null)
        {
            Id = id;
            Name = name;
            Income = income;
            Reservation = new List<Reservation>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal? Income { get; set; }
        public List<Reservation> Reservation { get; set; }
        private Airport()
        {
            Reservation = new List<Reservation>();
        }
    }
}
