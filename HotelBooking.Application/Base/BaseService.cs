
using AutoMapper;
using HotelBooking.Infrastructure.Interfaces;

namespace HotelBooking.Application.Base
{
    /// <summary>
    /// BaseService class.
    /// </summary>
    public abstract class BaseService
    {
        /// <summary>
        /// The unit of work
        /// </summary>
        protected readonly IUnitOfWork UnitOfWork;

        /// <summary>
        /// The mapper
        /// </summary>
        protected readonly IMapper Mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseService" /> class.
        /// </summary>
        /// <param name="unitOfWork">The unit of work.</param>
        /// <param name="mapper">The mapper.</param>
        protected BaseService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            UnitOfWork = unitOfWork;
            Mapper = mapper;
        }
    }
}