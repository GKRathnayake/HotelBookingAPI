using HotelBooking.API.Base;
using HotelBooking.Application.Services.Interfaces;
using HotelBooking.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.API.Controllers
{
    /// <summary>
    /// Hotel Controller class.
    /// </summary>
    /// <seealso cref="HotelBooking.API.Base.BaseController&lt;HotelBooking.Application.Services.Interfaces.IHotelService, HotelBooking.API.Controllers.HotelController&gt;" />
    [Route("api/hotel")]
    [ApiController]
    public class HotelController : BaseController<IHotelService, HotelController>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HotelController" /> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="service">The service.</param>
        public HotelController(ILogger<HotelController> logger, IHotelService service) : base(logger, service)
        {
        }

        /// <summary>
        /// Gets the hotel details by specified hotel identifier.
        /// API for viewing details and info about a specific hotel
        /// </summary>
        /// <param name="hotelId">The hotel identifier.</param>
        /// <returns></returns>
        [HttpGet()]
        [Route("get-by-id")]
        public async Task<ServiceResultVM<HotelVM>?> Get(int hotelId)
        {
            try
            {
                if (hotelId <= 0) return new ServiceResultVM<HotelVM>() { StatusCode = StatusCodes.Status400BadRequest };

                ServiceResultVM<HotelVM>? result = await this.Service.Get(hotelId);

                if (result == null) return new ServiceResultVM<HotelVM>() { StatusCode = StatusCodes.Status500InternalServerError };
                if (result.Items == null) return new ServiceResultVM<HotelVM>() { StatusCode = StatusCodes.Status404NotFound };
                if (result.Items.Count <= 0) return new ServiceResultVM<HotelVM>() { StatusCode = StatusCodes.Status404NotFound };

                result.StatusCode = StatusCodes.Status200OK;
                return result;
            }
            catch (Exception eX)
            {
                this.Logger.LogError(eX, "api/hotel/get-by-id");
                return new ServiceResultVM<HotelVM>() { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }

        /// <summary>
        /// Searches the hotels by specified criteria.
        /// API for listing/searching for a hotel.
        /// Search by City, Hotel name , Hotel Id and list all hotels.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        [HttpPost()]
        [Route("search")]
        public async Task<ServiceResultVM<HotelVM>?> Search(SearchRequestVM criteria)
        {
            try
            {
                if (criteria == null) return new ServiceResultVM<HotelVM>() { StatusCode = StatusCodes.Status400BadRequest };

                ServiceResultVM<HotelVM>? result = await this.Service.Search(criteria);

                if (result == null) return new ServiceResultVM<HotelVM>() { StatusCode = StatusCodes.Status500InternalServerError };
                if (result.Items == null) return new ServiceResultVM<HotelVM>() { StatusCode = StatusCodes.Status404NotFound };
                if (result.Items.Count <= 0) return new ServiceResultVM<HotelVM>() { StatusCode = StatusCodes.Status404NotFound };

                result.StatusCode = StatusCodes.Status200OK;
                return result;
            }
            catch (Exception eX)
            {
                this.Logger.LogError(eX, "api/hotel/search");
                return new ServiceResultVM<HotelVM>() { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }
    }
}
