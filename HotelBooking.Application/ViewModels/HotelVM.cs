using HotelBooking.Application.Base;
using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Application.ViewModels
{
    /// <summary>
    /// Hotel view model.
    /// </summary>
    /// <seealso cref="HotelBooking.Application.Base.BaseVM" />
    public class HotelVM : BaseVM
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HotelVM" /> class.
        /// </summary>
        public HotelVM()
        {
            this.HotelName = string.Empty;
            this.Description = string.Empty;
            this.Address = string.Empty;
            this.CountryName = string.Empty;
            this.CountryCode = string.Empty;
            this.CityName = string.Empty;
            this.Facilities = new List<FacilityVM>();
        }

        /// <summary>
        /// Gets or sets the hotel identifier.
        /// </summary>
        /// <value>
        /// The hotel identifier.
        /// </value>
        public int HotelId { get; set; }

        /// <summary>
        /// Gets or sets the hotel name.
        /// </summary>
        /// <value>
        /// The hotel name.
        /// </value>
        [Required()]
        [MaxLength(250)]
        public string HotelName { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [Required()]
        [MaxLength(1000)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        /// <value>
        /// The longitude.
        /// </value>
        [Required()]
        public decimal Longitude { get; set; }

        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        /// <value>
        /// The latitude.
        /// </value>
        [Required()]
        public decimal Latitude { get; set; }

        /// <summary>
        /// Gets or sets the country identifier.
        /// </summary>
        /// <value>
        /// The country identifier.
        /// </value>
        [Required()]
        public int CountryId { get; set; }

        /// <summary>
        /// Gets or sets the city identifier.
        /// </summary>
        /// <value>
        /// The city identifier.
        /// </value>
        [Required()]
        public int CityId { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        [Required()]
        [MaxLength(400)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the overall rating.
        /// </summary>
        /// <value>
        /// The overall rating.
        /// </value>
        [Required()]
        public decimal OverallRating { get; set; }

        /// <summary>
        /// Gets or sets the lowest room price.
        /// </summary>
        /// <value>
        /// The lowest room price.
        /// </value>
        [Required()]
        public decimal LowestRoomPrice { get; set; }

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

        /// <summary>
        /// Gets or sets the facilities.
        /// </summary>
        /// <value>
        /// The facilities.
        /// </value>
        public List<FacilityVM> Facilities { get; set; }

        /// <summary>
        /// Gets or sets the reviews.
        /// </summary>
        /// <value>
        /// The reviews.
        /// </value>
        public List<ReviewVM> Reviews { get; set; }
    }
}
