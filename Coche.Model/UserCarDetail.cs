using System;
using System.Collections.Generic;
using System.Text;

namespace Coche.Model
{
    public class UserCarDetail
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid CarId { get; set; }
        public string NumberPlate { get; set; }
        public string RegisteredYear { get; set; }
        public bool? IsDeleted { get; set; }
    }

}
