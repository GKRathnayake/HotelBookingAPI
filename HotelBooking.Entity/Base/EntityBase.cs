namespace HotelBooking.Entity.Base
{
    /// <summary>
    /// Entity base class without Id.
    /// </summary>
    public abstract class EntityBase
    {
        /// <summary>
        /// Gets or sets the updated date.
        /// </summary>
        /// <value>
        /// The updated date.
        /// </value>
        public virtual DateTime UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        public virtual DateTime CreatedDate { get; set; }
    }
}
