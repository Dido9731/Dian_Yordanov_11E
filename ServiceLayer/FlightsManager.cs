using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;

namespace ServiceLayer
{
    public class FlightsManager
    {
        private readonly FlightsContext context;
        public FlightsManager(FlightsDbContext dbContext)
        {
            context = new FlightsContext(dbContext);
        }

        public void Create(Flight item)
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
        public Flight Read(int key)
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
        public IEnumerable<Flight> ReadAll()
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
        public void Update(Flight item)
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
