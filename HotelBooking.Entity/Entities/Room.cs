using HotelBooking.Entity.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBooking.Entity.Entities
{
    /// <summary>
    /// Room entity.
    /// </summary>
    /// <seealso cref="HotelBooking.Entity.Base.EntityBaseWithId" />
    public class Room : EntityBase
    {
        #region [Constructor]

        /// <summary>
        /// Initializes a new instance of the <see cref="Room" /> class.
        /// </summary>
        public Room()
        {
            this.RoomNumber = string.Empty;
        }

        #endregion

        #region [Public Properties]

        /// <summary>
        /// Gets or sets the room identifier.
        /// </summary>
        /// <value>
        /// The room identifier.
        /// </value>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomId { get; set; }

        /// <summary>
        /// Gets or sets the room number.
        /// </summary>
        /// <value>
        /// The room number.
        /// </value>
        [Required()]
        [MaxLength(10)]
        public string RoomNumber { get; set; }

        /// <summary>
        /// Gets or sets the hotel identifier.
        /// </summary>
        /// <value>
        /// The hotel identifier.
        /// </value>
        [Required()]
        [ForeignKey("Hotel")]
        public int HotelId { get; set; }

        /// <summary>
        /// Gets or sets the room type identifier.
        /// </summary>
        /// <value>
        /// The room type identifier.
        /// </value>
        [Required()]
        [ForeignKey("RoomType")]
        public int RoomTypeId { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        [Required()]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the hotel.
        /// </summary>
        /// <value>
        /// The hotel.
        /// </value>
        public virtual Hotel? Hotel { get; set; }

        /// <summary>
        /// Gets or sets the type of the room.
        /// </summary>
        /// <value>
        /// The type of the room.
        /// </value>
        public virtual RoomType? RoomType { get; set; } 

        #endregion
    }
}
