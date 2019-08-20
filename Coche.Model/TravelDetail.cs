using System;
using System.Collections.Generic;
using System.Text;

namespace Coche.Model
{
    public class TravelDetail
    {
        public Guid Id { get; set; }
        public Guid DriverId { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public DateTime DateOfJourney { get; set; }
        public int NoOfSeats { get; set; }
        public decimal Price { get; set; }
        public bool? IsDeleted { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }

}
