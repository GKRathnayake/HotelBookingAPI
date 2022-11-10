using HotelBooking.Entity.Entities;

namespace HotelBooking.Infrastructure.Interfaces
{
    /// <summary>
    /// Contract for UnitOfWork.
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Gets the hotel entity collection.
        /// </summary>
        /// <value>
        /// The hotel entity collection.
        /// </value>
        IRepository<Hotel> Hotels { get; }

        /// <summary>
        /// Saves changes in to database.
        /// </summary>
        /// <returns></returns>
        Task<int> SaveChangesAsync();
    }
}
