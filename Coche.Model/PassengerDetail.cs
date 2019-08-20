using System;
using System.Collections.Generic;
using System.Text;

namespace Coche.Model
{
    public class PassengerDetail
    {
        public Guid Id { get; set; }
        public Guid TravelId { get; set; }
        public Guid UserId { get; set; }
        public int? BookedSeats { get; set; }
        public bool? IsDeleted { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }

}
