using Autofac;
using Com.API.Hotels.Core.Interfaces;
using Com.API.Hotels.Core.Services.Booking;
using Com.API.Hotels.Core.Services.Hotel;

namespace Com.API.Hotels.Core
{
    public class DefaultCoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<HotelService>()
                .As<IHotelServices>().InstancePerLifetimeScope();

            builder.RegisterType<BookingService>()
                .As<IBookingServices>().InstancePerLifetimeScope();
        }
    }
}
