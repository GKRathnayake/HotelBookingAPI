using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HotelBooking.Infrastructure.Interfaces
{
    /// <summary>
    /// Contract for Repository class.
    /// </summary>
    /// <typeparam name="T">Type of the entity</typeparam>
    public interface IRepository<T> where T : class
    {
        #region [Method Definitions]

        /// <summary>
        /// Finds the specified item/ items by given criteria..
        /// </summary>
        /// <param name="predicate">The predicate (criteria).</param>
        /// <returns></returns>
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Gets entire collection of entities for further evaluation.
        /// </summary>
        /// <returns>Entire collection of entities.</returns>
        DbSet<T> GetAll();

        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity to add.</param>
        void Add(T entity);

        /// <summary>
        /// Removes the specified entity.
        /// </summary>
        /// <param name="entity">The entity to remove.</param>
        void Remove(T entity); 

        #endregion
    }
}
