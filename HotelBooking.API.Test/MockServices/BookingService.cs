namespace HotelBooking.API.Test.MockServices
{
    internal class BookingService : IBookingService
    {
        public async Task<ServiceResultVM<BookingVM>?> Create(BookingVM mockVM)
        {
            mockVM.Id = 10;
            ServiceResultVM<BookingVM>? mockResult = new() { Items = new List<BookingVM>(new BookingVM[] { mockVM }) };

            await Task.Delay(100);

            return mockResult;
        }

        public async Task<ServiceResultVM<BookingVM>?> Get(int itemId)
        {
            BookingVM mockVM = new() { Id = itemId };
            ServiceResultVM<BookingVM>? mockResult = new() { Items = new List<BookingVM>(new BookingVM[] { mockVM }) };

            await Task.Delay(100);

            return mockResult;
        }

        public async Task<ServiceResultVM<BookingVM>?> Search(SearchRequestVM criteria)
        {
            ServiceResultVM<BookingVM>? mockResult = new()
            {
                Items = new List<BookingVM>(new BookingVM[] {
                    new BookingVM(){Id = 1 },
                    new BookingVM(){Id = 2 },
                    new BookingVM(){Id = 3 },
                    new BookingVM(){Id = 4 },
                  })
            };

            await Task.Delay(100);

            return mockResult;
        }
    }
}
