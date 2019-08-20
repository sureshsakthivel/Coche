using System;
using System.Collections.Generic;
using System.Text;

namespace Coche.Model
{
    public class UserRatingDetail
    {
        public Guid Id { get; set; }
        public Guid RatingId { get; set; }
        public Guid RatingRecipientId { get; set; }
        public Guid TravelId { get; set; }
        public Guid RatingProviderId { get; set; }
        public bool? IsDeleted { get; set; }
    }

}
