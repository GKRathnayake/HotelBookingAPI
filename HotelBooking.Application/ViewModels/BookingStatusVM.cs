using HotelBooking.Application.Base;
using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Application.ViewModels
{
    /// <summary>
    /// Booking status view model.
    /// </summary>
    /// <seealso cref="HotelBooking.Application.Base.BaseVM" />
    public class BookingStatusVM: BaseVM
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookingStatusVM"/> class.
        /// </summary>
        public BookingStatusVM()
        {
            this.Description = string.Empty;
        }

        /// <summary>
        /// Gets or sets the booking status identifier.
        /// </summary>
        /// <value>
        /// The booking status identifier.
        /// </value>
        public int BookingStatusId { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [Required()]
        [MaxLength(150)] 
        public string Description { get; set; }
    }
}
