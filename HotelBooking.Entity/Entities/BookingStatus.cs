﻿using HotelBooking.Entity.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBooking.Entity.Entities
{
    /// <summary>
    /// Booking status entity.
    /// </summary>
    /// <seealso cref="HotelBooking.Entity.Base.EntityBase" />
    public class BookingStatus: EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookingStatus"/> class.
        /// </summary>
        public BookingStatus()
        {
            this.Description = string.Empty;
        }

        /// <summary>
        /// Gets or sets the booking status identifier.
        /// </summary>
        /// <value>
        /// The booking status identifier.
        /// </value>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookingStatusId { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the bookings.
        /// </summary>
        /// <value>
        /// The bookings.
        /// </value>
        public virtual ICollection<Booking>? Bookings { get; set; }
    }
}
