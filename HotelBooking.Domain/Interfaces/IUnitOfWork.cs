using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //IAdressRepository Address
        //{
        //    get;
        //}
        //IEmailRepository Email
        //{
        //    get;
        //}
        //IPersonRepository Person
        //{
        //    get;
        //}

        /// <summary>
        /// Saves changes in to database.
        /// </summary>
        /// <returns></returns>
        int Save();
    }
}
