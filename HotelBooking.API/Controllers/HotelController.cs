using HotelBooking.Application.Services.Interfaces;
using HotelBooking.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.API.Controllers
{
    /// <summary>
    /// Hotel Controller class.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/hotel")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        /// <summary>
        /// The service
        /// </summary>
        protected readonly IHotelService Service;

        /// <summary>
        /// The logger
        /// </summary>
        protected readonly ILogger<HotelController> Logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="HotelController" /> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="service">The service.</param>
        public HotelController(ILogger<HotelController> logger, IHotelService service)
        {
            this.Logger = logger;
            this.Service = service;
        }

        /// <summary>
        /// Gets the hotel details by specified hotel identifier.
        /// API for viewing details and info about a specific hotel
        /// </summary>
        /// <param name="hotelId">The hotel identifier.</param>
        /// <returns></returns>
        [HttpGet()]
        [Route("get-by-id")]
        public async Task<HotelVM?> Get(int hotelId)
        {
            try
            {
                return await this.Service.Get(hotelId);
            }
            catch (Exception eX)
            {
                this.Logger.LogError(eX, "Get");
                return null;
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
        public async Task<SearchResultVM<HotelVM>?> Search(SearchRequestVM criteria)
        {
            try
            {
                return await this.Service.Search(criteria);
            }
            catch (Exception eX)
            {
                this.Logger.LogError(eX, "Search");
                return null;
            }
        }
    }
}
