using HotelBooking.Application.ViewModels;

namespace HotelBooking.Application.Services.Interfaces
{
    /// <summary>
    /// Contract for HotelService
    /// </summary>
    public interface IHotelService
    {
        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="hotelId">The hotel identifier.</param>
        /// <returns></returns>
        Task<HotelVM?> Get(int hotelId);

        /// <summary>
        /// Creates the specified hotel.
        /// </summary>
        /// <param name="hotel">The hotel.</param>
        /// <returns></returns>
        Task<HotelVM?> Create(HotelVM hotel);

        /// <summary>
        /// Searches the specified criteria.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        Task<SearchResultVM<HotelVM>?> Search(SearchRequestVM criteria);
    }
}