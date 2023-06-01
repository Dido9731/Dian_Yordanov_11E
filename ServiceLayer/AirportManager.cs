using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingLayer
{
    class AirportManager
    {
        private readonly AirportContext context;
        public AirportManager(FlightsDbContext dbContext)
        {
            context = new AirportContext(dbContext);
        }

        public void Create(Airport item)
        {
            try
            {
                context.Create(item);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Airport Read(int key)
        {
            try
            {
                return context.Read(key);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IEnumerable<Airport> ReadAll()
        {
            try
            {
                return context.ReadAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Update(Airport item)
        {
            try
            {
                context.Update(item);
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
                context.Delete(key);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
