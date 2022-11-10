using HotelBooking.Application.Base;
using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Application.ViewModels
{
    /// <summary>
    /// Review view model.
    /// </summary>
    /// <seealso cref="HotelBooking.Application.Base.BaseVMWithId" />
    public class ReviewVM : BaseVMWithId
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewVM"/> class.
        /// </summary>
        public ReviewVM()
        {
            this.Comment = string.Empty;
            this.HotelName = string.Empty;
            this.CountryCode = string.Empty;
            this.CountryName = string.Empty;
            this.CityName = string.Empty;
        }

        /// <summary>
        /// Gets or sets the hotel identifier.
        /// </summary>
        /// <value>
        /// The hotel identifier.
        /// </value>
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
        /// Gets or sets the hotel name.
        /// </summary>
        /// <value>
        /// The hotel name.
        /// </value>
        public string HotelName { get; set; }

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

        /// <summary>
        /// Gets or sets the name of the city.
        /// </summary>
        /// <value>
        /// The name of the city.
        /// </value>
        public string CityName { get; set; }
    }
}
