using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Application.ViewModels
{
    /// <summary>
    /// Facility view model.
    /// </summary>
    public class FacilityVM
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FacilityVM"/> class.
        /// </summary>
        public FacilityVM()
        {
            this.Description = string.Empty;
        }

        /// <summary>
        /// Gets or sets the facility identifier.
        /// </summary>
        /// <value>
        /// The facility identifier.
        /// </value>
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
    }
}
