using HotelBooking.Entity.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBooking.Entity.Entities
{
    /// <summary>
    /// Booking entity.
    /// </summary>
    /// <seealso cref="HotelBooking.Entity.Base.EntityBaseWithId" />
    public class Booking : EntityBaseWithId
    {
        #region [Constructor]

        /// <summary>
        /// Initializes a new instance of the <see cref="Booking"/> class.
        /// </summary>
        public Booking()
        {
            this.AdditionalInstructions = string.Empty;
        } 

        #endregion

        #region [Public Properties]

        /// <summary>
        /// Gets or sets the room identifier.
        /// </summary>
        /// <value>
        /// The room identifier.
        /// </value>
        [ForeignKey("Room")]
        public int RoomId { get; set; }

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
        [ForeignKey("BookingStatus")]
        public int BookingStatusId { get; set; }

        /// <summary>
        /// Gets or sets the booking status.
        /// </summary>
        /// <value>
        /// The booking status.
        /// </value>
        public virtual BookingStatus BookingStatus { get; set; }

        /// <summary>
        /// Gets or sets the room.
        /// </summary>
        /// <value>
        /// The room.
        /// </value>
        public virtual Room Room { get; set; } 

        #endregion
    }
}
