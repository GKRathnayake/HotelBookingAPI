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
        /// Initializes a new instance of the <see cref="HotelController"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="service">The service.</param>
        public HotelController(ILogger<HotelController> logger, IHotelService service)
        {
            this.Logger = logger;
            this.Service = service;
        }

        /// <summary>
        /// Gets the specified hotel identifier.
        /// </summary>
        /// <param name="hotelId">The hotel identifier.</param>
        /// <returns></returns>
        [HttpGet(Name = "get-by-id")]
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
    }
}
