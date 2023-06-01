using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class AirportContext : IDb<Airport, int>
    {
        private readonly FlightsDbContext dbContext;
        public AirportContext(FlightsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Airport item)
        {
            try
            {
                dbContext.Airports.Add(item);
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
                Airport airportFromDb = Read(key);
                dbContext.Airports.Remove(airportFromDb);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Airport Read(int key, bool useNavigationalProperties = false)
        {
            try
            {
                return dbContext.Airports.Find(key);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Airport> ReadAll(bool useNavigationalProperties = false)
        {
            try
            {
                return dbContext.Airports.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Airport item, bool useNavigationalProperties = false)
        {
            try
            {
                Airport airportFromDb = Read(item.Id);
                dbContext.Entry(airportFromDb).CurrentValues.SetValues(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
