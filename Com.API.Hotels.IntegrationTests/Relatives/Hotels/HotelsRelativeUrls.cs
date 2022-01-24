using Com.API.Hotels.IntegrationTests.Relatives.Base;
using System;

namespace Com.API.Hotels.IntegrationTests.Relatives.Hotels
{
    public class HotelsRelativeUrls : BaseRelative
	{
		static readonly Lazy<HotelsRelativeUrls> instance = new Lazy<HotelsRelativeUrls>(() => new HotelsRelativeUrls());

		/// <summary>
		/// Singleton instance property
		/// </summary>
		public static HotelsRelativeUrls Instance
		{
			get { return instance.Value; }
		}

		public string Hotels => $"{BaseRelativeUrl}​/hotels​";
		public string HotelById(Guid HotelId) => $"{BaseRelativeUrl}​/hotels​/{HotelId}​/details";
	}
}
