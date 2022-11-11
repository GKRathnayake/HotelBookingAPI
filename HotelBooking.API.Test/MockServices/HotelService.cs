namespace HotelBooking.API.Test.MockServices
{
    /// <summary>
    /// Hotel Service class.
    /// </summary>
    /// <seealso cref="HotelBooking.Application.Base.BaseService" />
    /// <seealso cref="HotelBooking.Application.Services.Interfaces.IHotelService" />
    public class HotelService : IHotelService
    {
        public async Task<ServiceResultVM<HotelVM>?> Create(HotelVM hotel)
        {
            HotelVM mockVM = new() { HotelId = 10 };
            ServiceResultVM<HotelVM>? mockResult = new() { Items = new List<HotelVM>(new HotelVM[] { mockVM }) };

            await Task.Delay(100);

            return mockResult;
        }

        public async Task<ServiceResultVM<HotelVM>?> Get(int hotelId)
        {
            HotelVM mockVM = new() { HotelId = hotelId };
            ServiceResultVM<HotelVM>? mockResult = new() { Items = new List<HotelVM>(new HotelVM[] { mockVM }) };

            await Task.Delay(100);

            return mockResult;
        }

        public async Task<ServiceResultVM<HotelVM>?> Search(SearchRequestVM criteria)
        {
            ServiceResultVM<HotelVM>? mockResult = new()
            {
                Items = new List<HotelVM>(new HotelVM[] {
                    new HotelVM(){HotelId = 1 },
                    new HotelVM(){HotelId = 2 },
                    new HotelVM(){HotelId = 3 },
                    new HotelVM(){HotelId = 4 },
                  })
            };

            await Task.Delay(100);

            return mockResult;
        }
    }
}
