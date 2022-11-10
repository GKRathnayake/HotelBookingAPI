using HotelBooking.Entity.Entities;
using HotelBooking.Infrastructure.Interfaces;

namespace HotelBooking.Infrastructure
{
    /// <summary>
    /// UnitOfWork class.
    /// </summary>
    /// <seealso cref="HotelBooking.Infrastructure.Interfaces.IUnitOfWork" />
    public class UnitOfWork : IUnitOfWork
    {
        #region [Private Members]

        /// <summary>
        /// The context
        /// </summary>
        private readonly AppDbContext context; 

        #endregion

        #region [Public Properties/ Repositories]

        /// <summary>
        /// Gets the hotel entity collection.
        /// </summary>
        /// <value>
        /// The hotel entity collection.
        /// </value>
        public IRepository<Hotel> Hotels
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the bookings.
        /// </summary>
        /// <value>
        /// The bookings.
        /// </value>
        public IRepository<Booking> Bookings
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the rooms.
        /// </summary>
        /// <value>
        /// The rooms.
        /// </value>
        public IRepository<Room> Rooms
        {
            get;
            private set;
        }

        #endregion

        #region [Constructor]

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitOfWork"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public UnitOfWork(AppDbContext context)
        {
            this.context = context;
            this.Hotels = new Repository<Hotel>(context);
            this.Bookings = new Repository<Booking>(context);
            this.Rooms = new Repository<Room>(context);
        } 

        #endregion

        #region [Public Methods]

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            context.Dispose();
        }

        /// <summary>
        /// Saves changes in to database.
        /// </summary>
        /// <returns></returns>
        public async Task<int> SaveChangesAsync()
        {
            return await context.SaveChangesAsync();
        } 

        #endregion
    }
}
