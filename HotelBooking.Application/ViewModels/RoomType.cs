using HotelBooking.Application.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBooking.Application.ViewModels
{
    /// <summary>
    /// Room type view model.
    /// </summary>
    public class RoomType : BaseVM
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomType"/> class.
        /// </summary>
        public RoomType()
        {
            this.Description = string.Empty;
        }

        /// <summary>
        /// Gets or sets the room type identifier.
        /// </summary>
        /// <value>
        /// The room type identifier.
        /// </value>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomTypeId { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [Required()]
        [MaxLength(150)] 
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the rooms.
        /// </summary>
        /// <value>
        /// The rooms.
        /// </value>
        public virtual ICollection<RoomVM>? Rooms { get; set; }
    }
}
