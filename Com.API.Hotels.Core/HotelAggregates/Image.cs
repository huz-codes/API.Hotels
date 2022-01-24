using Com.API.Hotels.SharedKernel;
using System;

namespace Com.API.Hotels.Core.Aggregates
{
    public class Image : BaseEntity
    {
        public Guid ImageId { get; set; }
        public string ImageName { get; set; }
        public string ImagePath { get; set; }

        public Guid PropertyId { get; set; }
        public Property Property  { get; set; }
        public Guid HotelId { get; set; }
        public Hotel Hotel { get; set; }
    }
}
