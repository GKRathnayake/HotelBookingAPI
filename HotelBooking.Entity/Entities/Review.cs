using HotelBooking.Entity.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBooking.Entity.Entities
{
    /// <summary>
    /// Review entity.
    /// </summary>
    /// <seealso cref="HotelBooking.Entity.Base.EntityBaseWithId" />
    public class Review : EntityBaseWithId
    {
        #region [Constructor]

        /// <summary>
        /// Initializes a new instance of the <see cref="Review"/> class.
        /// </summary>
        public Review()
        {
            this.Comment = string.Empty;
        }

        #endregion

        #region [Public Properties]

        /// <summary>
        /// Gets or sets the hotel identifier.
        /// </summary>
        /// <value>
        /// The hotel identifier.
        /// </value>
        [ForeignKey("Hotel")]
        public int HotelId { get; set; }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        [Required()]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the rating.
        /// </summary>
        /// <value>
        /// The rating.
        /// </value>
        [Required()]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Rating { get; set; }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        /// <value>
        /// The comment.
        /// </value>
        [Required()]
        [MaxLength(1500)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the hotel.
        /// </summary>
        /// <value>
        /// The hotel.
        /// </value>
        public virtual Hotel? Hotel { get; set; } 

        #endregion
    }
}
