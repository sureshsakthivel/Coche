using System;

namespace Coche.Model
{
    public class ProfileInfo
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string MobileNumber { get; set; }
        public bool? IsMobileNumberVerified { get; set; }
        public string EmailId { get; set; }
        public bool? IsEmailIdVerified { get; set; }
        public string FacebookId { get; set; }
        public string Description { get; set; }
        public byte[] Photo { get; set; }
        public string Password { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}
