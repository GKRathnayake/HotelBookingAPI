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
        /// <summary>
        /// The context
        /// </summary>
        private readonly AppDbContext context;

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
        /// Initializes a new instance of the <see cref="UnitOfWork"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public UnitOfWork(AppDbContext context)
        {
            this.context = context;
            Hotels = new Repository<Hotel>(context);
        }

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
    }
}
