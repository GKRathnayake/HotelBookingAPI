using AutoMapper;
using AutoMapper.QueryableExtensions;
using HotelBooking.Application.Base;
using HotelBooking.Application.Services.Interfaces;
using HotelBooking.Application.ViewModels;
using HotelBooking.Entity.Entities;
using HotelBooking.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography;
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
        public async Task<ServiceResultVM<HotelVM>?> Create(HotelVM hotel)
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
        public async Task<ServiceResultVM<HotelVM>?> Get(int hotelId)
        {
            var entity = await (from h in this.UnitOfWork.Hotels.GetAll()
                                where h.HotelId == hotelId
                                select new
                                {
                                    Hotel = h,
                                    CountryName = (h.Country != null) ? h.Country.CountryName : string.Empty,
                                    CountryCode = (h.Country != null) ? h.Country.Code : String.Empty,
                                    CityName = (h.City != null) ? h.City.CityName : String.Empty,
                                    Facilities = h.Facilities ?? new Facility[] { },
                                    Reviews = h.Reviews ?? new Review[] { },
                                }).FirstOrDefaultAsync();

            if (entity != null)
            {
                ServiceResultVM<HotelVM>? result = new();

                HotelVM hotel = this.Mapper.Map<HotelVM>(entity.Hotel);
                hotel.CountryName = entity.CountryName;
                hotel.CountryCode = entity.CountryCode;
                hotel.CityName = entity.CityName;

                hotel.Facilities = (from fa in (from f in entity.Facilities
                                                select new
                                                {
                                                    Facility = this.Mapper.Map<FacilityVM>(f)
                                                })
                                    select fa.Facility).ToList();

                hotel.Reviews = (from fa in (from f in entity.Reviews
                                             select new
                                             {
                                                 Review = this.Mapper.Map<ReviewVM>(f)
                                             })
                                 select fa.Review).ToList();

                result.Items.Add(hotel);

                return result;
            }

            return new ServiceResultVM<HotelVM>();
        }

        /// <summary>
        /// Searches the specified criteria.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public async Task<ServiceResultVM<HotelVM>?> Search(SearchRequestVM criteria)
        {
            ServiceResultVM<HotelVM> result = new();

            var query = from h in this.UnitOfWork.Hotels.GetAll()
                        select new
                        {
                            Hotel = h,
                            CountryName = (h.Country != null) ? h.Country.CountryName : string.Empty,
                            CountryCode = (h.Country != null) ? h.Country.Code : String.Empty,
                            CityName = (h.City != null) ? h.City.CityName : String.Empty,
                            Facilities = h.Facilities ?? new Facility[] { }
                        };

            var qResult = from h in this.UnitOfWork.Hotels.GetAll()
                          where h.HotelId == -1
                          select new
                          {
                              Hotel = h,
                              CountryName = (h.Country != null) ? h.Country.CountryName : string.Empty,
                              CountryCode = (h.Country != null) ? h.Country.Code : String.Empty,
                              CityName = (h.City != null) ? h.City.CityName : String.Empty,
                              Facilities = h.Facilities ?? new Facility[] { }
                          };

            criteria.SearchText ??= string.Empty;
            criteria.SearchText = criteria.SearchText.ToLower();

            if (criteria.SearchFilter == SearchFilter.ById)
            {
                qResult = query.Where(q => q.Hotel.HotelId == criteria.ItemCode);
            }
            else if (criteria.SearchFilter == SearchFilter.ByTitle)
            {
                // qResult = query.Where(q => q.Hotel.HotelName.ToLower().Contains(criteria.SearchText));
                //
                //  Utilizes SQL Server Full Text Search Compatibility.
                //
                qResult = query.Where(q => EF.Functions.Contains(q.Hotel.HotelName, criteria.SearchText) == true);
            }
            else if (criteria.SearchFilter == SearchFilter.ByDescription)
            {
                // qResult = query.Where(q => q.Hotel.Description.ToLower().Contains(criteria.SearchText));
                //
                //  Utilizes SQL Server Full Text Search Compatibility.
                //
                qResult = query.Where(q => EF.Functions.Contains(q.Hotel.Description, criteria.SearchText) == true);
            }
            else if (criteria.SearchFilter == SearchFilter.ByAddress)
            {
                // qResult = query.Where(q => q.Hotel.Address.ToLower().Contains(criteria.SearchText));
                //
                //  Utilizes SQL Server Full Text Search Compatibility.
                //
                qResult = query.Where(q => EF.Functions.Contains(q.Hotel.Address, criteria.SearchText) == true);
            }
            else if (criteria.SearchFilter == SearchFilter.ByCity)
            {
                qResult = query.Where(q => q.Hotel.CityId == criteria.CityId);
            }
            else if (criteria.SearchFilter == SearchFilter.ByMyLocation)
            {
                //
                //  Search can be made based on users current location.
                //  Search criteria has properties to store users current location info and
                //  radius (distance). Those details will be useful for searching "hotels near by me".
                //
            }

            var data = await (from q in qResult
                              select new
                              {
                                  Hotel = this.Mapper.Map<HotelVM>(q.Hotel),
                                  q.CountryName,
                                  q.CountryCode,
                                  q.CityName,
                                  q.Facilities
                              }).ToListAsync();

            data.ForEach(d =>
            {
                d.Hotel.CountryName = d.CountryName;
                d.Hotel.CountryCode = d.CountryCode;
                d.Hotel.CityName = d.CityName;
                d.Hotel.Facilities = (from fa in (from f in d.Facilities
                                                  select new
                                                  {
                                                      Facility = this.Mapper.Map<FacilityVM>(f)
                                                  })
                                      select fa.Facility).ToList();
            });

            result.Items = (from d in data select d.Hotel).ToList();
            return result;
        }
    }
}
