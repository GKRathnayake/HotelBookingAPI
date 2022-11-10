using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBooking.Entity.Entities
{
    /// <summary>
    /// Country entity.
    /// </summary>
    public class Country
    {
        #region [Constructor]

        /// <summary>
        /// Initializes a new instance of the <see cref="Country"/> class.
        /// </summary>
        public Country()
        {
            this.CountryName = string.Empty;
            this.Code = string.Empty;
        }

        #endregion

        #region [Public Properties]

        /// <summary>
        /// Gets or sets the country identifier.
        /// </summary>
        /// <value>
        /// The country identifier.
        /// </value>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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

        /// <summary>
        /// Gets or sets the cities.
        /// </summary>
        /// <value>
        /// The cities.
        /// </value>
        public virtual ICollection<City>? Cities { get; set; }

        /// <summary>
        /// Gets or sets the hotels.
        /// </summary>
        /// <value>
        /// The hotels.
        /// </value>
        public virtual ICollection<Hotel>? Hotels { get; set; } 

        #endregion
    }
}
