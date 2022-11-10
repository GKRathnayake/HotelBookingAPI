using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBooking.Entity.Entities
{
    /// <summary>
    /// Facility entity.
    /// </summary>
    public class Facility
    {
        #region [Constructor]

        /// <summary>
        /// Initializes a new instance of the <see cref="Facility"/> class.
        /// </summary>
        public Facility()
        {
            this.Description = string.Empty;
        }

        #endregion

        #region [Public Properties]

        /// <summary>
        /// Gets or sets the facility identifier.
        /// </summary>
        /// <value>
        /// The facility identifier.
        /// </value>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FacilityId { get; set; }

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
        /// Gets or sets the hotel.
        /// </summary>
        /// <value>
        /// The hotel.
        /// </value>
        public virtual ICollection<Hotel>? Hotels { get; set; } 

        #endregion
    }
}
