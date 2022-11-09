using HotelBooking.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HotelBooking.Infrastructure
{
    /// <summary>
    /// Generic repository calss.
    /// Super class for all the repositories.
    /// </summary>
    /// <typeparam name="T">Type of the entity.</typeparam>
    /// <seealso cref="HotelBooking.Domain.Interfaces.IRepository&lt;T&gt;" />
    /// <seealso cref="HotelBooking.Domain.Interfaces.IRepository&lt;T&gt;" />
    public class Repository<T> : IRepository<T> where T : class
    {
        /// <summary>
        /// The entities
        /// </summary>
        protected readonly DbSet<T> _entities;

        /// <summary>
        /// Initializes a new instance of the <see cref="Repository{T}"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public Repository(DbContext context)
        {
            _entities = context.Set<T>();
        }

        /// <summary>
        /// Gets entire collection of entities for further evaluation.
        /// </summary>
        /// <returns>
        /// Entire collection of entities.
        /// </returns>
        public IEnumerable<T> GetAll()
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
        public void Add(T entity)
        {
            _entities.Add(entity);
        }

        /// <summary>
        /// Removes the specified entity.
        /// </summary>
        /// <param name="entity">The entity to remove.</param>
        public void Remove(T entity)
        {
            _entities.Remove(entity);
        }       
    }
}
