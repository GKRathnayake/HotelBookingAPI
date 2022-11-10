using HotelBooking.API.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.API.Base
{
    /// <summary>
    /// Base Controller class.
    /// </summary>
    /// <typeparam name="TService">The type of the service.</typeparam>
    /// <typeparam name="TControler">The type of the controler.</typeparam>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [ApiController]
    public class BaseController<TService, TControler> : ControllerBase
    {
        #region [Protected Members]

        /// <summary>
        /// The service
        /// </summary>
        protected readonly TService Service;

        /// <summary>
        /// The logger
        /// </summary>
        protected readonly ILogger<TControler> Logger;

        #endregion

        #region [Constructor]

        /// <summary>
        /// Initializes a new instance of the <see cref="BookingController" /> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="service">The service.</param>
        public BaseController(ILogger<TControler> logger, TService service)
        {
            Logger = logger;
            Service = service;
        } 

        #endregion
    }
}
