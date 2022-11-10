using HotelBooking.API.Base;
using HotelBooking.Application.Services.Interfaces;
using HotelBooking.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.API.Controllers
{
    /// <summary>
    /// Booking Controller class.
    /// </summary>
    /// <seealso cref="HotelBooking.API.Base.BaseController&lt;HotelBooking.Application.Services.Interfaces.IBookingService, HotelBooking.API.Controllers.BookingController&gt;" />
    [Route("api/booking")]
    [ApiController]
    public class BookingController : BaseController<IBookingService, BookingController>
    {
        #region [Constructor]

        /// <summary>
        /// Initializes a new instance of the <see cref="BookingController" /> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="service">The service.</param>
        public BookingController(ILogger<BookingController> logger, IBookingService service) : base(logger, service) { }

        #endregion

        #region [Web API Methods]

        /// <summary>
        /// Creates the specified booking.
        /// API for placing a booking
        /// </summary>
        /// <param name="booking">The booking.</param>
        /// <returns></returns>
        [HttpPost()]
        [Route("create")]
        public async Task<ServiceResultVM<BookingVM>?> Create(BookingVM booking)
        {
            try
            {
                //
                //  Validate client inputs and return status accordingly.
                //
                if (booking == null) return new ServiceResultVM<BookingVM>() { StatusCode = StatusCodes.Status400BadRequest };
                //
                //  Store data in database
                //
                ServiceResultVM<BookingVM>? result = await this.Service.Create(booking);
                //
                //  Validate status and report status back to client.
                //
                if (result == null) return new ServiceResultVM<BookingVM>() { StatusCode = StatusCodes.Status500InternalServerError };
                if (result.Items == null) return new ServiceResultVM<BookingVM>() { StatusCode = StatusCodes.Status404NotFound };

                result.StatusCode = StatusCodes.Status200OK;
                return result;
            }
            catch (Exception eX)
            {
                this.Logger.LogError(eX, "api/booking/create");
                return new ServiceResultVM<BookingVM>() { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }

        /// <summary>
        /// Gets the booking details by specified booking identifier.
        /// API for viewing details and info about a specific booking
        /// </summary>
        /// <param name="bookingId">The booking identifier.</param>
        /// <returns></returns>
        [HttpGet()]
        [Route("get-by-id")]
        public async Task<ServiceResultVM<BookingVM>?> Get(int bookingId)
        {
            try
            {
                if (bookingId <= 0) return new ServiceResultVM<BookingVM>() { StatusCode = StatusCodes.Status400BadRequest };

                ServiceResultVM<BookingVM>? result = await this.Service.Get(bookingId);

                if (result == null) return new ServiceResultVM<BookingVM>() { StatusCode = StatusCodes.Status500InternalServerError };
                if (result.Items == null) return new ServiceResultVM<BookingVM>() { StatusCode = StatusCodes.Status404NotFound };
                if (result.Items.Count <= 0) return new ServiceResultVM<BookingVM>() { StatusCode = StatusCodes.Status404NotFound };

                result.StatusCode = StatusCodes.Status200OK;
                return result;
            }
            catch (Exception eX)
            {
                this.Logger.LogError(eX, "api/booking/get-by-id");
                return new ServiceResultVM<BookingVM>() { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }

        /// <summary>
        /// Searches the bookings by specified criteria.
        /// API for listing/searching for a booking.
        /// Search by City, Booking name , Booking Id and list all bookings.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        [HttpPost()]
        [Route("search")]
        public async Task<ServiceResultVM<BookingVM>?> Search(SearchRequestVM criteria)
        {
            try
            {
                if (criteria == null) return new ServiceResultVM<BookingVM>() { StatusCode = StatusCodes.Status400BadRequest };

                ServiceResultVM<BookingVM>? result = await this.Service.Search(criteria);

                if (result == null) return new ServiceResultVM<BookingVM>() { StatusCode = StatusCodes.Status500InternalServerError };
                if (result.Items == null) return new ServiceResultVM<BookingVM>() { StatusCode = StatusCodes.Status404NotFound };
                if (result.Items.Count <= 0) return new ServiceResultVM<BookingVM>() { StatusCode = StatusCodes.Status404NotFound };

                result.StatusCode = StatusCodes.Status200OK;
                return result;
            }
            catch (Exception eX)
            {
                this.Logger.LogError(eX, "api/booking/search");
                return new ServiceResultVM<BookingVM>() { StatusCode = StatusCodes.Status500InternalServerError };
            }
        } 

        #endregion
    }
}
