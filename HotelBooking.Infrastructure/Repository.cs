using HotelBooking.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HotelBooking.Infrastructure
{
    /// <summary>
    /// Generic repository calss.
    /// </summary>
    /// <typeparam name="T">Type of the entity.</typeparam>
    /// <seealso cref="HotelBooking.Infrastructure.Interfaces.IRepository&lt;T&gt;" />
    public class Repository<T> : IRepository<T> where T : class
    {
        #region [Private Fields]

        /// <summary>
        /// The entities
        /// </summary>
        private readonly DbSet<T> _entities;

        #endregion

        #region [Constructor]

        /// <summary>
        /// Initializes a new instance of the <see cref="Repository{T}"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public Repository(DbContext context)
        {
            _entities = context.Set<T>();
        }

        #endregion

        #region [Public Methods]

        /// <summary>
        /// Gets entire collection of entities for further evaluation.
        /// </summary>
        /// <returns>
        /// Entire collection of entities.
        /// </returns>
        public DbSet<T> GetAll()
        {
            return _entities;
        }

        /// <summary>
        /// Finds the specified item/ items by given criteria..
        /// </summary>
        /// <param name="predicate">The predicate (criteria).</param>
        /// <returns></returns>
        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _entities.Where(predicate);
        }

        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity to add.</param>
        public async void Add(T entity)
        {
            await _entities.AddAsync(entity);
        }

        /// <summary>
        /// Removes the specified entity.
        /// </summary>
        /// <param name="entity">The entity to remove.</param>
        public void Remove(T entity)
        {
            _entities.Remove(entity);
        }

        #endregion
    }
}
