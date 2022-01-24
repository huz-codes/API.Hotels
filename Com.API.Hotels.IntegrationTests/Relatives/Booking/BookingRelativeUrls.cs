using Com.API.Hotels.IntegrationTests.Relatives.Base;
using System;

namespace Com.API.Hotels.IntegrationTests.Relatives.Booking
{

    public class BookingRelativeUrls : BaseRelative
	{
		static readonly Lazy<BookingRelativeUrls> instance = new Lazy<BookingRelativeUrls>(() => new BookingRelativeUrls());

		/// <summary>
		/// Singleton instance property
		/// </summary>
		public static BookingRelativeUrls Instance
		{
			get { return instance.Value; }
		}

		public string Book(Guid HotelId) => $"{BaseRelativeUrl}​/hotels​/{HotelId}​/book";
	}
}
