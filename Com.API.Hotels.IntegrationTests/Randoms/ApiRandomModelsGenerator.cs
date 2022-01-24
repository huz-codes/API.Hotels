using System;
using Tynamix.ObjectFiller;

namespace Com.API.Hotels.IntegrationTests.Randoms
{
    public class ApiRandomModelsGenerator
    {
        static readonly Lazy<ApiRandomModelsGenerator> instance = new Lazy<ApiRandomModelsGenerator>(() => new ApiRandomModelsGenerator());

        /// <summary>
        /// Singleton instance
        /// </summary>
        public static ApiRandomModelsGenerator Instance
        {
            get { return instance.Value; }
        }
        public TGenerator ApiRandomsClassGenerator<TGenerator>() where TGenerator : Filler<TGenerator>
        {
            TGenerator Random = new Filler<TGenerator>().Create();
            return Random;
        }

        public Models.Booking.BookingTestsModel ApiRandomBookingGenerator() =>
           new Filler<Models.Booking.BookingTestsModel>().Create();
    }
}
