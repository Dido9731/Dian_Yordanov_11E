using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class ReservationContext : IDb<Reservation, int>
    {
            private readonly FlightsDbContext dbContext;
        public ReservationContext(FlightsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Create(Reservation item)
        {
            try
            {
                dbContext.Reservations.Add(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(int key)
        {
            try
            {
                Reservation reservationFromDb = Read(key);
                dbContext.Reservations.Remove(reservationFromDb);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Reservation Read(int key, bool useNavigationalProperties = false)
        {
            try
            {
                return dbContext.Reservations.FirstOrDefault(c => c.Id == key);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Reservation> ReadAll(bool useNavigationalProperties = false)
        {
            try
            {
                return dbContext.Reservations.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Reservation item, bool useNavigationalProperties = false)
        {
            try
            {
                Reservation reservationFromDb = Read(item.Id);
                dbContext.Entry(reservationFromDb).CurrentValues.SetValues(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
