namespace HotelBooking.API.Test
{
    public class BookingControllerUnitTest: UnitTestBase<BookingController>
    {
        #region ["api/booking/create" API Method Tests]

        [Fact]
        public async void Send_Booking_Null_GettingServiceResultNotNull()
        {
            BookingVM mockBooking = null;
            ILogger<BookingController> mockLogger = GetLogger();
            IBookingService mockService = new M.BookingService();

            var controler = new BookingController(mockLogger, mockService);

            ServiceResultVM<BookingVM>? result = await controler.Create(mockBooking);

            Assert.NotNull(result);
        }

        [Fact]
        public async void Send_Booking_Null_GettingServiceResultStatus400()
        {
            BookingVM mockBooking = null;
            ILogger<BookingController> mockLogger = GetLogger();
            IBookingService mockService = new M.BookingService();

            var controler = new BookingController(mockLogger, mockService);

            ServiceResultVM<BookingVM>? result = await controler.Create(mockBooking);

            Assert.NotNull(result);
            Assert.Equal(result.StatusCode, 400);
        }

        [Fact]
        public async void Send_Booking_GettingServiceResultStatus200()
        {
            BookingVM mockBooking = new();
            ILogger<BookingController> mockLogger = GetLogger();
            IBookingService mockService = new M.BookingService();

            var controler = new BookingController(mockLogger, mockService);

            ServiceResultVM<BookingVM>? result = await controler.Create(mockBooking);

            Assert.NotNull(result);
            Assert.Equal(result.StatusCode, 200);
        }

        [Fact]
        public async void Send_Booking_GettingServiceResultItemsNonNull()
        {
            BookingVM mockBooking = new();
            ILogger<BookingController> mockLogger = GetLogger();
            IBookingService mockService = new M.BookingService();

            var controler = new BookingController(mockLogger, mockService);

            ServiceResultVM<BookingVM>? result = await controler.Create(mockBooking);

            Assert.NotNull(result);
            Assert.Equal(result.StatusCode, 200);
            Assert.NotNull(result.Items);
        }

        [Fact]
        public async void Send_Booking_GettingServiceResultItemsFirstItemNonNull()
        {
            BookingVM mockBooking = new();
            ILogger<BookingController> mockLogger = GetLogger();
            IBookingService mockService = new M.BookingService();

            var controler = new BookingController(mockLogger, mockService);

            ServiceResultVM<BookingVM>? result = await controler.Create(mockBooking);

            Assert.NotNull(result);
            Assert.Equal(result.StatusCode, 200);
            Assert.NotNull(result.Items);
            Assert.NotNull(result.Items[0]);
        }

        [Fact]
        public async void Send_Booking_GettingServiceResultItemsFirstItemsId10()
        {
            BookingVM mockBooking = new();
            ILogger<BookingController> mockLogger = GetLogger();
            IBookingService mockService = new M.BookingService();

            var controler = new BookingController(mockLogger, mockService);

            ServiceResultVM<BookingVM>? result = await controler.Create(mockBooking);

            Assert.NotNull(result);
            Assert.Equal(result.StatusCode, 200);
            Assert.NotNull(result.Items);
            Assert.NotNull(result.Items[0]);
            Assert.Equal(result.Items[0].Id, 10);
        }

        #endregion

        #region ["api/booking/get-by-id" API Method Tests]

        [Fact]
        public async void Send_BookingId_0_GettingServiceResultNonNull()
        {
            int mockId = 0;
            ILogger<BookingController> mockLogger = GetLogger();
            IBookingService mockService = new M.BookingService();

            var controler = new BookingController(mockLogger, mockService);

            ServiceResultVM<BookingVM>? result = await controler.Get(mockId);

            Assert.NotNull(result);
        }

        [Fact]
        public async void Send_BookingId_0_GettingServiceResultStatus400()
        {
            int mockId = 0;
            ILogger<BookingController> mockLogger = GetLogger();
            IBookingService mockService = new M.BookingService();

            var controler = new BookingController(mockLogger, mockService);

            ServiceResultVM<BookingVM>? result = await controler.Get(mockId);

            Assert.NotNull(result);
            Assert.Equal(result.StatusCode, 400);
        }

        [Fact]
        public async void Send_BookingId_GettingServiceResultStatusCode200()
        {
            int mockId = 10;
            ILogger<BookingController> mockLogger = GetLogger();
            IBookingService mockService = new M.BookingService();

            var controler = new BookingController(mockLogger, mockService);

            ServiceResultVM<BookingVM>? result = await controler.Get(mockId);

            Assert.NotNull(result);
            Assert.Equal(result.StatusCode, 200);
        }

        [Fact]
        public async void Send_BookingId_GettingServiceResultItemsNonNull()
        {
            int mockId = 10;
            ILogger<BookingController> mockLogger = GetLogger();
            IBookingService mockService = new M.BookingService();

            var controler = new BookingController(mockLogger, mockService);

            ServiceResultVM<BookingVM>? result = await controler.Get(mockId);

            Assert.NotNull(result);
            Assert.Equal(result.StatusCode, 200);
            Assert.NotNull(result.Items);
        }

        [Fact]
        public async void Send_BookingId_GettingServiceResultItemsFirstItemNonNull()
        {
            int mockId = 10;
            ILogger<BookingController> mockLogger = GetLogger();
            IBookingService mockService = new M.BookingService();

            var controler = new BookingController(mockLogger, mockService);

            ServiceResultVM<BookingVM>? result = await controler.Get(mockId);

            Assert.NotNull(result);
            Assert.Equal(result.StatusCode, 200);
            Assert.NotNull(result.Items);
            Assert.NotNull(result.Items[0]);
        }

        [Fact]
        public async void Send_BookingId_GettingServiceResultItemsFirstItemMatchWithMockId()
        {
            int mockId = 10;
            ILogger<BookingController> mockLogger = GetLogger();
            IBookingService mockService = new M.BookingService();

            var controler = new BookingController(mockLogger, mockService);

            ServiceResultVM<BookingVM>? result = await controler.Get(mockId);

            Assert.NotNull(result);
            Assert.Equal(result.StatusCode, 200);
            Assert.NotNull(result.Items);
            Assert.NotNull(result.Items[0]);
            Assert.Equal(result.Items[0].Id, mockId);
        }

        #endregion

        #region ["api/booking/search" API Method Tests]

        [Fact]
        public async void Send_SearchCriteria_Null_GettingServiceResultNonNull()
        {
            SearchRequestVM mockRequest = null;
            ILogger<BookingController> mockLogger = GetLogger();
            IBookingService mockService = new M.BookingService();

            var controler = new BookingController(mockLogger, mockService);

            ServiceResultVM<BookingVM>? result = await controler.Search(mockRequest);

            Assert.NotNull(result);
        }

        [Fact]
        public async void Send_SearchCriteria_Null_GettingServiceResultStatus400()
        {
            SearchRequestVM mockRequest = null;
            ILogger<BookingController> mockLogger = GetLogger();
            IBookingService mockService = new M.BookingService();

            var controler = new BookingController(mockLogger, mockService);

            ServiceResultVM<BookingVM>? result = await controler.Search(mockRequest);

            Assert.NotNull(result);
            Assert.Equal(result.StatusCode, 400);
        }

        [Fact]
        public async void Send_SearchCriteria_GettingServiceResultStatus200()
        {
            SearchRequestVM mockRequest = new();
            ILogger<BookingController> mockLogger = GetLogger();
            IBookingService mockService = new M.BookingService();

            var controler = new BookingController(mockLogger, mockService);

            ServiceResultVM<BookingVM>? result = await controler.Search(mockRequest);

            Assert.NotNull(result);
            Assert.Equal(result.StatusCode, 200);
        }

        [Fact]
        public async void Send_SearchCriteria_GettingServiceResultItemsNonNull()
        {
            SearchRequestVM mockRequest = new();
            ILogger<BookingController> mockLogger = GetLogger();
            IBookingService mockService = new M.BookingService();

            var controler = new BookingController(mockLogger, mockService);

            ServiceResultVM<BookingVM>? result = await controler.Search(mockRequest);

            Assert.NotNull(result);
            Assert.Equal(result.StatusCode, 200);
            Assert.NotNull(result.Items);
        }

        [Fact]
        public async void Send_SearchCriteria_GettingServiceResultItemsGetFourItemsNonNull()
        {
            SearchRequestVM mockRequest = new();
            ILogger<BookingController> mockLogger = GetLogger();
            IBookingService mockService = new M.BookingService();

            var controler = new BookingController(mockLogger, mockService);

            ServiceResultVM<BookingVM>? result = await controler.Search(mockRequest);

            Assert.NotNull(result);
            Assert.Equal(result.StatusCode, 200);
            Assert.NotNull(result.Items);

            for (int i = 0; i < 4; i++)
            {
                Assert.NotNull(result.Items[i]);
            }
        }

        [Fact]
        public async void Send_SearchCriteria_GettingServiceResultItemsMatchWithMockIds()
        {
            SearchRequestVM mockRequest = new();
            ILogger<BookingController> mockLogger = GetLogger();
            IBookingService mockService = new M.BookingService();
            int[] mockIds = new int[] { 1, 2, 3, 4 };

            var controler = new BookingController(mockLogger, mockService);

            ServiceResultVM<BookingVM>? result = await controler.Search(mockRequest);

            Assert.NotNull(result);
            Assert.Equal(result.StatusCode, 200);
            Assert.NotNull(result.Items);

            for (int i = 0; i < 4; i++)
            {
                Assert.NotNull(result.Items[i]);
                Assert.Equal(result.Items[i].Id, mockIds[i]);
            }
        }

        #endregion
    }
}