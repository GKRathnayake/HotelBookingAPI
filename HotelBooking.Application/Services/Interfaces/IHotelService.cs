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
        public Task<HotelVM?> Get(int hotelId);

        /// <summary>
        /// Creates the specified hotel.
        /// </summary>
        /// <param name="hotel">The hotel.</param>
        /// <returns></returns>
        public Task<HotelVM?> Create(HotelVM hotel);
    }
}