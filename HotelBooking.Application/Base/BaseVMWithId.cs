using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBooking.Application.Base
{
    /// <summary>
    /// View model base class with Id.
    /// </summary>
    /// <seealso cref="HotelBooking.Application.Base.BaseVM" />
    public abstract class BaseVMWithId : BaseVM
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public virtual int Id { get; set; }
    }
}
