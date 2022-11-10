using HotelBooking.Application.Base;
using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Application.ViewModels
{
    /// <summary>
    /// Booking view model.
    /// </summary>
    /// <seealso cref="HotelBooking.Application.Base.BaseVMWithId" />
    public class BookingVM : BaseVMWithId
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookingVM"/> class.
        /// </summary>
        public BookingVM()
        {
            this.AdditionalInstructions = string.Empty;
            this.BookingStatus = string.Empty;
        }

        /// <summary>
        /// Gets or sets the room identifier.
        /// </summary>
        /// <value>
        /// The room identifier.
        /// </value>
        public int? RoomId { get; set; }

        /// <summary>
        /// Gets or sets the checkin date.
        /// </summary>
        /// <value>
        /// The checkin date.
        /// </value>
        [Required()] 
        public DateTime CheckinDate { get; set; }

        /// <summary>
        /// Gets or sets the checkout date.
        /// </summary>
        /// <value>
        /// The checkout date.
        /// </value>
        [Required()]
        public DateTime CheckoutDate { get; set; }

        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        /// <value>
        /// The customer identifier.
        /// </value>
        [Required()] 
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the additional instructions.
        /// </summary>
        /// <value>
        /// The additional instructions.
        /// </value>
        [MaxLength(1000)] 
        public string AdditionalInstructions { get; set; }

        /// <summary>
        /// Gets or sets the booking status identifier.
        /// </summary>
        /// <value>
        /// The booking status identifier.
        /// </value>
        [Required()]
        public int BookingStatusId { get; set; }

        /// <summary>
        /// Gets or sets the booking status.
        /// </summary>
        /// <value>
        /// The booking status.
        /// </value>
        public string BookingStatus { get; set; }
    }
}
