namespace HotelBooking.API.Test.Base
{
    public class UnitTestBase<TControler> where TControler : class
    {
        #region [Private Static Methods - Sopport Functions]

        protected static ILogger<TControler> GetLogger()
        {
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .BuildServiceProvider();

            var factory = serviceProvider.GetService<ILoggerFactory>();

            var logger = factory.CreateLogger<TControler>();

            return logger;
        }

        #endregion
    }
}
