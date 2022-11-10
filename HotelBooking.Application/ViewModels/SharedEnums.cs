namespace HotelBooking.Application.ViewModels
{
    using System.Runtime.Serialization;
    /// <summary>
    /// Search Filter
    /// </summary>
    [DataContract()]
    public enum SearchFilter : int
    {
        /// <summary>
        /// Default Error Handler
        /// </summary>
        [EnumMember()]
        None = 0,

        /// <summary>
        /// Search By Id
        /// </summary>
        [EnumMember()]
        ById = 1,

        /// <summary>
        /// Search By Title
        /// </summary>
        [EnumMember()]
        ByTitle = 2,

        /// <summary>
        /// Search By City
        /// </summary>
        [EnumMember()]
        ByCity = 3,

        /// <summary>
        /// Search by my location
        /// </summary>
        [EnumMember()]
        ByMyLocation = 4,

        /// <summary>
        /// Search by parent Id
        /// </summary>
        [EnumMember()]
        ByParentId = 5,

        /// <summary>
        /// Search by parent Id and date range.
        /// </summary>
        [EnumMember()]
        ByParentIdAndDateRange = 5,

        /// <summary>
        /// Search by parent Id, date range and category.
        /// </summary>
        [EnumMember()]
        ByParentIdAndDateRangeAndCategory = 6,

        /// <summary>
        /// Search By Description
        /// </summary>
        [EnumMember()]
        ByDescription = 7,

        /// <summary>
        /// Search By Address
        /// </summary>
        [EnumMember()]
        ByAddress = 8
    };

}