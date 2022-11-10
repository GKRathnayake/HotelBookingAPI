using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBooking.Entity.Base
{
    /// <summary>
    /// Entity base class with Id.
    /// </summary>
    /// <seealso cref="HotelBooking.Entity.Base.EntityBase" />
    public abstract class EntityBaseWithId: EntityBase
    {
        #region [Public Properties]

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; } 

        #endregion
    }
}
