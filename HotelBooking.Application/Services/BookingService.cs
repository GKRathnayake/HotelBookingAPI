using AutoMapper;
using HotelBooking.Application.Base;
using HotelBooking.Application.Services.Interfaces;
using HotelBooking.Application.ViewModels;
using HotelBooking.Entity.Entities;
using HotelBooking.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelBooking.Application.Services
{
    /// <summary>
    /// Booking Service class.
    /// </summary>
    /// <seealso cref="HotelBooking.Application.Base.BaseService" />
    /// <seealso cref="HotelBooking.Application.Services.Interfaces.IBookingService" />
    public class BookingService : BaseService, IBookingService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookingService" /> class.
        /// </summary>
        /// <param name="unitOfWork">The unit of work.</param>
        /// <param name="mapper">The mapper.</param>
        public BookingService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        /// <summary>
        /// Creates the specified booking.
        /// </summary>
        /// <param name="booking">The booking.</param>
        /// <returns></returns>
        public async Task<ServiceResultVM<BookingVM>?> Create(BookingVM booking)
        {
            //
            //  Get current bookings of the respective hotel by room type
            //
            SearchRequestVM criteria = new()
            {
                ItemCode = booking.HotelId,
                TypeId = booking.RoomTypeId,
                StartDate = booking.CheckinDate,
                EndDate = booking.CheckoutDate,
                SearchFilter = SearchFilter.ByParentIdAndDateRangeAndCategory
            };
            //
            //  Search current bookings of the hotel (based on hotel and room type)
            //
            ServiceResultVM<BookingVM>? currentBookings = await this.Search(criteria);

            if (currentBookings == null) return null;
            currentBookings.Items ??= new List<BookingVM>();
            //
            //  Get currently utilized room Ids.
            //
            var utilizedRoomIds = currentBookings.Items.Select(r => r.RoomId).ToList();
            //
            //  Read database and get one available room Id (of the given hotel by given room type)
            //
            var availableRoomId = await (from r in this.UnitOfWork.Rooms.GetAll()
                                         where r.HotelId == booking.HotelId &&
                                              r.RoomTypeId == booking.RoomTypeId &&
                                              utilizedRoomIds.Contains(r.RoomId) == false
                                         select r.RoomId).FirstOrDefaultAsync();

            if (availableRoomId <= 0) return null;
            //
            //  Allocate selected rom for current booking.
            //  There must be so many other variables to consider when we select a room.
            //  Those elements are not considered here.
            //
            booking.RoomId = availableRoomId;
            Booking entity = this.Mapper.Map<Booking>(booking);
            entity.UpdatedDate = null;

            this.UnitOfWork.Bookings.Add(entity);
            await this.UnitOfWork.SaveChangesAsync();

            var result = await this.Get(entity.Id);

            return result;
        }

        /// <summary>
        /// Gets the specified booking by given identifier.
        /// </summary>
        /// <param name="bookingId">The booking identifier.</param>
        /// <returns></returns>
        public async Task<ServiceResultVM<BookingVM>?> Get(int bookingId)
        {
            var entity = await (from b in this.UnitOfWork.Bookings.GetAll()
                                where b.Id == bookingId
                                select new
                                {
                                    Booking = b,
                                    b.Room.Hotel,
                                    BookingStatus = b.BookingStatus.Description
                                }).FirstOrDefaultAsync();

            if (entity != null)
            {
                ServiceResultVM<BookingVM>? result = new();

                BookingVM booking = this.Mapper.Map<BookingVM>(entity.Booking);
                booking.BookingStatusDescription = entity.BookingStatus;
                booking.HotelId = entity.Hotel.HotelId;

                result.Items.Add(booking);

                return result;
            }

            return new ServiceResultVM<BookingVM>();
        }

        /// <summary>
        /// Searches booking by the specified criteria.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public async Task<ServiceResultVM<BookingVM>?> Search(SearchRequestVM criteria)
        {
            ServiceResultVM<BookingVM> result = new();

            var query = from b in this.UnitOfWork.Bookings.GetAll()
                        select new
                        {
                            Booking = b,
                            b.Room,
                            b.Room.Hotel,
                            BookingStatus = b.BookingStatus.Description
                        };

            var qResult = from b in this.UnitOfWork.Bookings.GetAll()
                          where b.Id == -1
                          select new
                          {
                              Booking = b,
                              b.Room,
                              b.Room.Hotel,
                              BookingStatus = b.BookingStatus.Description
                          };

            criteria.SearchText ??= string.Empty;
            criteria.SearchText = criteria.SearchText.ToLower();

            if (criteria.SearchFilter == SearchFilter.ById)
            {
                qResult = query.Where(q => q.Booking.Id == criteria.ItemCode);
            }
            else if (criteria.SearchFilter == SearchFilter.ByParentId)
            {
                qResult = query.Where(q => q.Hotel.HotelId == criteria.ItemCode);
            }
            else if (criteria.SearchFilter == SearchFilter.ByParentIdAndDateRange)
            {
                //
                //  Filter bookings by hotel and date period.
                //
                qResult = query.Where(q => q.Hotel.HotelId == criteria.ItemCode);
                qResult = qResult.Where(q => (q.Booking.CheckinDate <= criteria.StartDate &&
                                            q.Booking.CheckoutDate >= criteria.StartDate) ||
                                            (q.Booking.CheckinDate >= criteria.StartDate &&
                                            q.Booking.CheckinDate <= criteria.EndDate &&
                                            q.Booking.CheckoutDate <= criteria.EndDate));
            }
            else if (criteria.SearchFilter == SearchFilter.ByParentIdAndDateRangeAndCategory)
            {//
                //  Filter bookings by hotel and date period and room type.
                //
                qResult = query.Where(q => q.Hotel.HotelId == criteria.ItemCode && q.Room.RoomTypeId == criteria.TypeId);
                qResult = qResult.Where(q => (q.Booking.CheckinDate <= criteria.StartDate &&
                                            q.Booking.CheckoutDate >= criteria.StartDate) ||
                                            (q.Booking.CheckinDate >= criteria.StartDate &&
                                            q.Booking.CheckinDate <= criteria.EndDate &&
                                            q.Booking.CheckoutDate <= criteria.EndDate));
            }

            var data = await (from q in qResult
                              select new
                              {
                                  Booking = this.Mapper.Map<BookingVM>(q.Booking),
                                  q.Hotel,
                                  q.BookingStatus
                              }).ToListAsync();

            data.ForEach(d =>
            {
                d.Booking.HotelId = d.Hotel.HotelId;
                d.Booking.BookingStatusDescription = d.BookingStatus;
            });

            result.Items = (from d in data select d.Booking).ToList();
            return result;
        }
    }
}
