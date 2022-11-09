using HotelBooking.Entity.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Entity.Entities
{
    /// <summary>
    /// Hotel entity.
    /// </summary>
    /// <seealso cref="HotelBooking.Entity.Base.EntityBaseWithId" />
    public class Hotel : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Hotel" /> class.
        /// </summary>
        public Hotel()
        {
            this.Name = string.Empty;
            this.Description = string.Empty;
            this.Address = string.Empty;
        }

        /// <summary>
        /// Gets or sets the hotel identifier.
        /// </summary>
        /// <value>
        /// The hotel identifier.
        /// </value>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HotelId { get; set; }

        /// <summary>
        /// Gets or sets the hotel name.
        /// </summary>
        /// <value>
        /// The hotel name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        /// <value>
        /// The longitude.
        /// </value>
        public decimal Longitude { get; set; }

        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        /// <value>
        /// The latitude.
        /// </value>
        public decimal Latitude { get; set; }

        /// <summary>
        /// Gets or sets the country identifier.
        /// </summary>
        /// <value>
        /// The country identifier.
        /// </value>
        [ForeignKey("Country")]
        public int CountryId { get; set; }

        /// <summary>
        /// Gets or sets the city identifier.
        /// </summary>
        /// <value>
        /// The city identifier.
        /// </value>
        [ForeignKey("City")]
        public int CityId { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the overall rating.
        /// </summary>
        /// <value>
        /// The overall rating.
        /// </value>
        public decimal OverallRating { get; set; }

        /// <summary>
        /// Gets or sets the lowest room price.
        /// </summary>
        /// <value>
        /// The lowest room price.
        /// </value>
        public decimal LowestRoomPrice { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        public virtual Country? Country { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public virtual City? City { get; set; }

        /// <summary>
        /// Gets or sets the facility.
        /// </summary>
        /// <value>
        /// The facility.
        /// </value>
        public virtual ICollection<Facility>? Facilities { get; set; }
    }
}
