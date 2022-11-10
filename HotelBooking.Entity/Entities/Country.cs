﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBooking.Entity.Entities
{
    /// <summary>
    /// Country entity.
    /// </summary>
    public class Country
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Country"/> class.
        /// </summary>
        public Country()
        {
            this.Name = string.Empty;
            this.Code = string.Empty;
        }

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
        public string Name { get; set; }

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
    }
}
