﻿using HotelBooking.Infrastructure.Interfaces;

namespace HotelBooking.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        // private PeopleContext context;

        public UnitOfWork(/*PeopleContext context*/)
        {
            //this.context = context;
            //Address = new AddressRepository(this.context);
            //Email = new EmailRepository(this.context);
            //Person = new PersonRepository(this.context);
        }

        //public IAdressRepository Address
        //{
        //    get;
        //    private set;
        //}
        //public IEmailRepository Email
        //{
        //    get;
        //    private set;
        //}
        //public IPersonRepository Person
        //{
        //    get;
        //    private set;
        //}
        public void Dispose()
        {
            // context.Dispose();
        }
        public int Save()
        {
            return 0;// context.SaveChanges();
        }
    }
}
