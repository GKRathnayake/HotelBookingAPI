using HotelBooking.Application.ViewModels;

namespace HotelBooking.Application.Services.Interfaces
{
    /// <summary>
    /// Contract for base service.
    /// </summary>
    /// <typeparam name="TVM">The type of the VM.</typeparam>
    public interface IBaseService<TVM>
    {
        /// <summary>
        /// Gets the specified item.
        /// </summary>
        /// <param name="bookingId">The item identifier.</param>
        /// <returns></returns>
        Task<ServiceResultVM<TVM>?> Get(int itemId);

        /// <summary>
        /// Creates the specified entity.
        /// </summary>
        /// <param name="hotel">The VM.</param>
        /// <returns></returns>
        Task<ServiceResultVM<TVM>?> Create(TVM vm);

        /// <summary>
        /// Searches by the specified criteria.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        Task<ServiceResultVM<TVM>?> Search(SearchRequestVM criteria);
    }
}