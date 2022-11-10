using HotelBooking.Application.Base;
using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Application.ViewModels
{
    /// <summary>
    /// City view model.
    /// </summary>
    /// <seealso cref="HotelBooking.Application.Base.BaseVM" />
    public class CityVM: BaseVM
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CityVM"/> class.
        /// </summary>
        public CityVM()
        {
            this.CityName = string.Empty;
            this.CountryName = string.Empty;
            this.CountryCode = string.Empty;
        }

        /// <summary>
        /// Gets or sets the city identifier.
        /// </summary>
        /// <value>
        /// The city identifier.
        /// </value>
        public int CityId { get; set; }

        /// <summary>
        /// Gets or sets the country identifier.
        /// </summary>
        /// <value>
        /// The country identifier.
        /// </value>
        [Required()]
        public int CountryId { get; set; }

        /// <summary>
        /// Gets or sets the city name.
        /// </summary>
        /// <value>
        /// The city name.
        /// </value>
        [Required()]
        [MaxLength(400)]
        public string CityName { get; set; }

        /// <summary>
        /// Gets or sets the name of the country.
        /// </summary>
        /// <value>
        /// The name of the country.
        /// </value>
        public string CountryName { get; set; }

        /// <summary>
        /// Gets or sets the country code.
        /// </summary>
        /// <value>
        /// The country code.
        /// </value>
        public string CountryCode { get; set; }
    }
}
