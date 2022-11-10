using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Application.ViewModels
{
    /// <summary>
    /// Country view model.
    /// </summary>
    public class CountryVM
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountryVM"/> class.
        /// </summary>
        public CountryVM()
        {
            this.CountryName = string.Empty;
            this.Code = string.Empty;
        }

        /// <summary>
        /// Gets or sets the country identifier.
        /// </summary>
        /// <value>
        /// The country identifier.
        /// </value>
        public int CountryId { get; set; }

        /// <summary>
        /// Gets or sets the country name.
        /// </summary>
        /// <value>
        /// The country name.
        /// </value>
        [Required()]
        [MaxLength(500)]
        public string CountryName { get; set; }

        /// <summary>
        /// Gets or sets the country code.
        /// </summary>
        /// <value>
        /// The country code.
        /// </value>
        [Required()]
        [MaxLength(10)]
        public string Code { get; set; }
    }
}
