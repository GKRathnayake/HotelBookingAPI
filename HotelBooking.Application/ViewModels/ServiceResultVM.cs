
namespace HotelBooking.Application.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    /// Service result VM class.
    /// </summary>
    /// <typeparam name="TListItem">The type of the list item.</typeparam>
    [Serializable()]
    [DataContract()]
    public class ServiceResultVM<TListItem>
    {
        #region [Constructor]

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceResultVM{TListItem}"/> class.
        /// </summary>
        public ServiceResultVM() { }

        #endregion

        #region [Public Properties]

        /// <summary>
        /// Gets or sets the total item count.
        /// </summary>
        /// <value>
        /// The total item count.
        /// </value>
        [DataMember()]
        public long TotalItemCount { get; set; }

        /// <summary>
        /// Gets or sets the current offset.
        /// </summary>
        /// <value>
        /// The current offset.
        /// </value>
        [DataMember()]
        public long CurrentOffset { get; set; }

        /// <summary>
        /// Gets or sets the size of the page.
        /// </summary>
        /// <value>
        /// The size of the page.
        /// </value>
        [DataMember()]
        public long PageSize { get; set; }

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        /// <value>
        /// The items.
        /// </value>
        [DataMember()]
        public List<TListItem> Items { get; set; } = new List<TListItem>();

        /// <summary>
        /// Gets or sets the status codes.
        /// Compare with Microsoft.AspNetCore.Http.StatusCodes class and determine the server response status.
        /// </summary>
        /// <value>
        /// The status codes.
        /// </value>
        public int StatusCode { get; set; }

        #endregion
    }
}
