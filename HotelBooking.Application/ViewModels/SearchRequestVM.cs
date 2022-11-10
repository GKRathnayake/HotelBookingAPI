
namespace HotelBooking.Application.ViewModels
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>
    /// Search Criteria VM object
    /// </summary>
    [DataContract()]
    public class SearchRequestVM
    {
        #region [Constructor]

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCriteria"/> class.
        /// </summary>
        public SearchRequestVM()
        {
            this.SearchText = String.Empty;
        }

        #endregion

        #region [Public Properties]

        /// <summary>
        /// Gets or sets the search filter.
        /// </summary>
        /// <value>
        /// The search filter.
        /// </value>
        public SearchFilter SearchFilter { get; set; }

        /// <summary>
        /// Gets or sets the search text.
        /// </summary>
        /// <value>
        /// The search text.
        /// </value>
        public string SearchText { get; set; }

        /// <summary>
        /// Gets or sets the item code.
        /// </summary>
        /// <value>
        /// The item code.
        /// </value>
        public int ItemCode { get; set; }

        /// <summary>
        /// Gets or sets the city identifier.
        /// </summary>
        /// <value>
        /// The city identifier.
        /// </value>
        public int CityId { get; set; }

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
        /// Gets or sets the distance.
        /// </summary>
        /// <value>
        /// The distance.
        /// </value>
        public int Distance { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>
        /// The start date.
        /// </value>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>
        /// The end date.
        /// </value>
        public DateTime EndDate { get; set; }

        #endregion
    }

}
