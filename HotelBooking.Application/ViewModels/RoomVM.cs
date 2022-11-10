using HotelBooking.Application.Base;
using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Application.ViewModels
{
    /// <summary>
    /// Room view model.
    /// </summary>
    /// <seealso cref="HotelBooking.Application.Base.BaseVMWithId" />
    public class RoomVM : BaseVMWithId
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomVM" /> class.
        /// </summary>
        public RoomVM()
        {
            this.RoomNumber = string.Empty;
            this.HotelName = string.Empty;
            this.CountryCode = string.Empty;
            this.CountryName = string.Empty;
            this.CityName = string.Empty;
            this.RoomType = string.Empty;
        }

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
        public int HotelId { get; set; }

        /// <summary>
        /// Gets or sets the room type identifier.
        /// </summary>
        /// <value>
        /// The room type identifier.
        /// </value>
        [Required()]
        public int RoomTypeId { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        [Required()]
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the name of the country.
        /// </summary>
        /// <value>
        /// The name of the country.
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

        /// <summary>
        /// Gets or sets the type of the room.
        /// </summary>
        /// <value>
        /// The type of the room.
        /// </value>
        public   string RoomType { get; set; }
    }
}
