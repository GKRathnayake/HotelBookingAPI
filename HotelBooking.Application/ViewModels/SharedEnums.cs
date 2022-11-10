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
        /// The by my location
        /// </summary>
        [EnumMember()]
        ByMyLocation = 4
    };

}