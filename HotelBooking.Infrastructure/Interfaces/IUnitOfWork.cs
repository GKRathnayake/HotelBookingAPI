using HotelBooking.Entity.Entities;

namespace HotelBooking.Infrastructure.Interfaces
{
    /// <summary>
    /// Contract for UnitOfWork.
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    public interface IUnitOfWork : IDisposable
    {
        #region [Property Definitions]

        /// <summary>
        /// Gets the hotel entity collection.
        /// </summary>
        /// <value>
        /// The hotel entity collection.
        /// </value>
        IRepository<Hotel> Hotels { get; }

        /// <summary>
        /// Gets the bookings.
        /// </summary>
        /// <value>
        /// The bookings.
        /// </value>
        IRepository<Booking> Bookings { get; }

        /// <summary>
        /// Gets the rooms.
        /// </summary>
        /// <value>
        /// The rooms.
        /// </value>
        IRepository<Room> Rooms { get; } 

        #endregion

        #region [Method Definitions]

        /// <summary>
        /// Saves changes in to database.
        /// </summary>
        /// <returns></returns>
        Task<int> SaveChangesAsync(); 

        #endregion
    }
}
