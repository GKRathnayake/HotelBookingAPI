namespace HotelBooking.API.Test
{
    public class HotelControllerUnitTest: UnitTestBase<HotelController>
    {
        #region ["api/hotel/get-by-id" API Method Tests]

        [Fact]
        public async void Send_HotelId_0_GettingServiceResultNonNull()
        {
            int mockId = 0;
            ILogger<HotelController> mockLogger = GetLogger();
            IHotelService mockService = new M.HotelService();

            var controler = new HotelController(mockLogger, mockService);

            ServiceResultVM<HotelVM>? result = await controler.Get(mockId);

            Assert.NotNull(result);
        }

        [Fact]
        public async void Send_HotelId_0_GettingServiceResultStatus400()
        {
            int mockId = 0;
            ILogger<HotelController> mockLogger = GetLogger();
            IHotelService mockService = new M.HotelService();

            var controler = new HotelController(mockLogger, mockService);

            ServiceResultVM<HotelVM>? result = await controler.Get(mockId);

            Assert.NotNull(result);
            Assert.Equal(result.StatusCode, 400);
        }

        [Fact]
        public async void Send_HotelId_GettingServiceResultStatusCode200()
        {
            int mockId = 10;
            ILogger<HotelController> mockLogger = GetLogger();
            IHotelService mockService = new M.HotelService();

            var controler = new HotelController(mockLogger, mockService);

            ServiceResultVM<HotelVM>? result = await controler.Get(mockId);

            Assert.NotNull(result);
            Assert.Equal(result.StatusCode, 200);
        }

        [Fact]
        public async void Send_HotelId_GettingServiceResultItemsNonNull()
        {
            int mockId = 10;
            ILogger<HotelController> mockLogger = GetLogger();
            IHotelService mockService = new M.HotelService();

            var controler = new HotelController(mockLogger, mockService);

            ServiceResultVM<HotelVM>? result = await controler.Get(mockId);

            Assert.NotNull(result);
            Assert.Equal(result.StatusCode, 200);
            Assert.NotNull(result.Items);
        }

        [Fact]
        public async void Send_HotelId_GettingServiceResultItemsFirstItemNonNull()
        {
            int mockId = 10;
            ILogger<HotelController> mockLogger = GetLogger();
            IHotelService mockService = new M.HotelService();

            var controler = new HotelController(mockLogger, mockService);

            ServiceResultVM<HotelVM>? result = await controler.Get(mockId);

            Assert.NotNull(result);
            Assert.Equal(result.StatusCode, 200);
            Assert.NotNull(result.Items);
            Assert.NotNull(result.Items[0]);
        }

        [Fact]
        public async void Send_HotelId_GettingServiceResultItemsFirstItemMatchWithMockId()
        {
            int mockId = 10;
            ILogger<HotelController> mockLogger = GetLogger();
            IHotelService mockService = new M.HotelService();

            var controler = new HotelController(mockLogger, mockService);

            ServiceResultVM<HotelVM>? result = await controler.Get(mockId);

            Assert.NotNull(result);
            Assert.Equal(result.StatusCode, 200);
            Assert.NotNull(result.Items);
            Assert.NotNull(result.Items[0]);
            Assert.Equal(result.Items[0].HotelId, mockId);
        }

        #endregion

        #region ["api/hotel/search" API Method Tests]

        [Fact]
        public async void Send_SearchCriteria_Null_GettingServiceResultNonNull()
        {
            SearchRequestVM mockRequest = null;
            ILogger<HotelController> mockLogger = GetLogger();
            IHotelService mockService = new M.HotelService();

            var controler = new HotelController(mockLogger, mockService);

            ServiceResultVM<HotelVM>? result = await controler.Search(mockRequest);

            Assert.NotNull(result);
        }

        [Fact]
        public async void Send_SearchCriteria_Null_GettingServiceResultStatus400()
        {
            SearchRequestVM mockRequest = null;
            ILogger<HotelController> mockLogger = GetLogger();
            IHotelService mockService = new M.HotelService();

            var controler = new HotelController(mockLogger, mockService);

            ServiceResultVM<HotelVM>? result = await controler.Search(mockRequest);

            Assert.NotNull(result);
            Assert.Equal(result.StatusCode, 400);
        }

        [Fact]
        public async void Send_SearchCriteria_GettingServiceResultStatus200()
        {
            SearchRequestVM mockRequest = new();
            ILogger<HotelController> mockLogger = GetLogger();
            IHotelService mockService = new M.HotelService();

            var controler = new HotelController(mockLogger, mockService);

            ServiceResultVM<HotelVM>? result = await controler.Search(mockRequest);

            Assert.NotNull(result);
            Assert.Equal(result.StatusCode, 200);
        }

        [Fact]
        public async void Send_SearchCriteria_GettingServiceResultItemsNonNull()
        {
            SearchRequestVM mockRequest = new();
            ILogger<HotelController> mockLogger = GetLogger();
            IHotelService mockService = new M.HotelService();

            var controler = new HotelController(mockLogger, mockService);

            ServiceResultVM<HotelVM>? result = await controler.Search(mockRequest);

            Assert.NotNull(result);
            Assert.Equal(result.StatusCode, 200);
            Assert.NotNull(result.Items);
        }

        [Fact]
        public async void Send_SearchCriteria_GettingServiceResultItemsGetFourItemsNonNull()
        {
            SearchRequestVM mockRequest = new();
            ILogger<HotelController> mockLogger = GetLogger();
            IHotelService mockService = new M.HotelService();

            var controler = new HotelController(mockLogger, mockService);

            ServiceResultVM<HotelVM>? result = await controler.Search(mockRequest);

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
            ILogger<HotelController> mockLogger = GetLogger();
            IHotelService mockService = new M.HotelService();
            int[] mockIds = new int[] { 1, 2, 3, 4 };

            var controler = new HotelController(mockLogger, mockService);

            ServiceResultVM<HotelVM>? result = await controler.Search(mockRequest);

            Assert.NotNull(result);
            Assert.Equal(result.StatusCode, 200);
            Assert.NotNull(result.Items);

            for (int i = 0; i < 4; i++)
            {
                Assert.NotNull(result.Items[i]);
                Assert.Equal(result.Items[i].HotelId, mockIds[i]);
            }
        }

        #endregion
    }
}