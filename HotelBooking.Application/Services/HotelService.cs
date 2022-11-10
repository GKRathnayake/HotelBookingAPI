using AutoMapper;
using HotelBooking.Application.Base;
using HotelBooking.Application.Services.Interfaces;
using HotelBooking.Application.ViewModels;
using HotelBooking.Entity.Entities;
using HotelBooking.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Application.Services
{
    /// <summary>
    /// Hotel Service class.
    /// </summary>
    /// <seealso cref="HotelBooking.Application.Base.BaseService" />
    /// <seealso cref="HotelBooking.Application.Services.Interfaces.IHotelService" />
    public class HotelService : BaseService, IHotelService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HotelService" /> class.
        /// </summary>
        /// <param name="unitOfWork">The unit of work.</param>
        /// <param name="mapper">The mapper.</param>
        public HotelService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        /// <summary>
        /// Creates the specified hotel.
        /// </summary>
        /// <param name="hotel">The hotel.</param>
        /// <returns></returns>
        public async Task<HotelVM?> Create(HotelVM hotel)
        {
            Hotel entity = this.Mapper.Map<Hotel>(hotel);

            this.UnitOfWork.Hotels.Add(entity);
            await this.UnitOfWork.SaveChangesAsync();

            var result = await this.Get(entity.HotelId);

            return result;
        }

        /// <summary>
        /// Gets the specified hotel identifier.
        /// </summary>
        /// <param name="hotelId">The hotel identifier.</param>
        /// <returns></returns>
        public async Task<HotelVM?> Get(int hotelId)
        {
            Hotel? entity = await this.UnitOfWork.Hotels.GetAll().FirstOrDefaultAsync(h => h.HotelId == hotelId);

            if (entity != null)
            {
                HotelVM hotel = this.Mapper.Map<HotelVM>(entity);

                hotel.CountryName = (entity.Country != null) ? entity.Country.CountryName : String.Empty;
                hotel.CountryCode = (entity.Country != null) ? entity.Country.Code : String.Empty;
                hotel.CityName = (entity.City != null) ? entity.City.CityName : String.Empty;

                return hotel;
            }

            return null;
        }
    }
}
