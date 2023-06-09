﻿using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;
using BusinessLayer;

namespace TestingLayer
{
    class ReservationManager
    {
        private readonly ReservationContext context;
        public ReservationManager(FlightsDbContext dbContext)
        {
            context = new ReservationContext(dbContext);
        }

        public void Create(Reservation item)
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
        public Reservation Read(int key)
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
        public IEnumerable<Reservation> ReadAll()
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
        public void Update(Reservation item)
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
